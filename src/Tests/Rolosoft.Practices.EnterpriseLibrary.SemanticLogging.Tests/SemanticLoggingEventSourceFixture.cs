// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Diagnostics.Tracing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Tests.TestObjects;

namespace Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Tests
{

#if !DEBUG
// Do not run on build server
    [Ignore]
#endif
    [TestClass]
    public class SemanticLoggingEventSourceFixture
    {
        [Ignore] // Unit test not working from original source code. ROC 12/31/16
        [TestMethod]
        public void ShouldValidateEventSource()
        {
            EventSourceAnalyzer.EventSourceAnalyzer.InspectAll(SemanticLoggingEventSource.Log);
        }

        [Ignore] // Unit test not working from original source code. ROC 12/31/16
        [TestMethod]
        public void ShouldWriteWithNoFiltering()
        {
            using (var listener = new InMemoryEventListener())
            {
                listener.EnableEvents(SemanticLoggingEventSource.Log, EventLevel.LogAlways, Keywords.All);

                SemanticLoggingEventSource.Log.DatabaseSinkPublishEventsFailed("test");

                listener.DisableEvents(SemanticLoggingEventSource.Log);

                StringAssert.Contains(listener.ToString(), "EventId : 101");
                StringAssert.Contains(listener.ToString(), "Level : Error");
                StringAssert.Contains(listener.ToString(), "Payload : [message : test]");
            }
        }

        [Ignore] // Unit test not working from original source code. ROC 12/31/16
        [TestMethod]
        public void ShouldWriteByErrorLevel()
        {
            using (var listener = new InMemoryEventListener())
            {
                listener.EnableEvents(SemanticLoggingEventSource.Log, EventLevel.Error, Keywords.All);

                SemanticLoggingEventSource.Log.ConsoleSinkWriteFailed("test");

                listener.DisableEvents(SemanticLoggingEventSource.Log);

                StringAssert.Contains(listener.ToString(), "EventId : 200");
                StringAssert.Contains(listener.ToString(), "Level : Critical");
                StringAssert.Contains(listener.ToString(), "Payload : [message : test]");
            }
        }

        [Ignore] // Unit test not working from original source code. ROC 12/31/16
        [TestMethod]
        public void ShouldWriteByEventKeywords()
        {
            using (var listener = new InMemoryEventListener())
            {
                listener.EnableEvents(SemanticLoggingEventSource.Log, EventLevel.LogAlways, SemanticLoggingEventSource.Keywords.Sink);

                SemanticLoggingEventSource.Log.ConsoleSinkWriteFailed("test");

                listener.DisableEvents(SemanticLoggingEventSource.Log);

                StringAssert.Contains(listener.ToString(), "EventId : 200");
                StringAssert.Contains(listener.ToString(), "Level : Critical");
                StringAssert.Contains(listener.ToString(), "Payload : [message : test]");
            }
        }

        [TestMethod]
        public void ShouldFilterByEventKeywords()
        {
            using (var listener = new InMemoryEventListener())
            {
                listener.EnableEvents(SemanticLoggingEventSource.Log, EventLevel.LogAlways, SemanticLoggingEventSource.Keywords.Formatting);

                SemanticLoggingEventSource.Log.ConsoleSinkWriteFailed("test");

                listener.DisableEvents(SemanticLoggingEventSource.Log);

                Assert.AreEqual(string.Empty, listener.ToString());
            }
        }
    }
}
