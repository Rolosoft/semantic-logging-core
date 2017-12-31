﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Configuration;

namespace Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Tests.Etw
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SemanticLogging.Etw.Configuration;

#if !DEBUG
// Do not run on build server
    [Ignore]
#endif
    [TestClass]
    public class given_traceEventServiceSettings_configuration
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void when_creating_instance_with_null_sessionName()
        {
            new TraceEventServiceSettings() { SessionNamePrefix = null };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void when_creating_instance_with_empty_sessionName()
        {
            new TraceEventServiceSettings() { SessionNamePrefix = string.Empty };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void when_creating_instance_with_max_sessionName_length()
        {
            new TraceEventServiceSettings() { SessionNamePrefix = new string('a', 201) };
        }

        [TestMethod]
        public void when_creating_instance_with_default_values()
        {
            var sut = new TraceEventServiceSettings();

            Assert.IsTrue(sut.SessionNamePrefix.StartsWith(Constants.DefaultSessionNamePrefix));
        }
    }
}
