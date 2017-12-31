// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Tests.TestObjects;

namespace Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Tests.Etw
{
    using System;
    using System.Xml.Linq;
    using Microsoft.Practices.EnterpriseLibrary.SemanticLogging.Tests.TestSupport;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SemanticLogging.Configuration;
    using Constants = SemanticLogging.Configuration.Constants;

    public abstract class given_consoleSinkElement : ContextBase
    {
        protected ISinkElement sut;
        private XElement element;

        protected override void Given()
        {
            element = new XElement(XName.Get("consoleSink", Constants.Namespace));

            sut = new ConsoleSinkElement();
        }
#if !DEBUG
// Do not run on build server
    [Ignore]
#endif
        [TestClass]
        public class when_query_for_canCreateSink : given_consoleSinkElement
        {
            [TestMethod]
            public void then_instance_can_be_created()
            {
                Assert.IsTrue(sut.CanCreateSink(element));
            }
        }
#if !DEBUG
// Do not run on build server
    [Ignore]
#endif
        [TestClass]
        public class when_createSink_with_default_parameters : given_consoleSinkElement
        {
            private IObserver<EventEntry> observer;

            protected override void When()
            {
                observer = sut.CreateSink(element);
            }

            [TestMethod]
            public void then_sink_is_created()
            {
                Assert.IsNotNull(observer);
            }
        }
#if !DEBUG
// Do not run on build server
    [Ignore]
#endif
        [TestClass]
        public class when_createSink_with_colorMapper_parameter : given_consoleSinkElement
        {
            private IObserver<EventEntry> observer;

            protected override void When()
            {
                element.Add(new XAttribute("colorMapperType", typeof(MockColorMapper).AssemblyQualifiedName));
                observer = sut.CreateSink(element);
            }

            [TestMethod]
            public void then_sink_is_created()
            {
                Assert.IsNotNull(MockColorMapper.Instance);
            }
        }
    }
}
