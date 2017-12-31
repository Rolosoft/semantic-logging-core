﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Threading;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Tests.TestObjects;
using Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Utility;

namespace Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Tests.Etw
{
#if !DEBUG
// Do not run on build server
    [Ignore]
#endif
    [TestClass]
    public class given_xmlUtil
    {
        [TestMethod]
        public void when_converting_toTimeSpan_from_null_attribute()
        {
            TimeSpan? result = ((XAttribute)null).ToTimeSpan();

            Assert.AreEqual((TimeSpan?)null, result);
        }

        [TestMethod]
        public void when_converting_toTimeSpan_from_infinite()
        {
            TimeSpan? result = new XAttribute("value", -1).ToTimeSpan();

            Assert.AreEqual(Timeout.InfiniteTimeSpan, result);
        }

        [TestMethod]
        public void when_converting_toTimeSpan_from_int()
        {
            TimeSpan? result = new XAttribute("value", 123).ToTimeSpan();

            Assert.AreEqual(TimeSpan.FromSeconds(123), result);
        }

        [TestMethod]
        public void when_creating_instance_from_element()
        {
            var element = new XElement("test", new XAttribute("type", "Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Tests.TestObjects.InMemoryEventListener, Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Tests"));
            var sut = XmlUtil.CreateInstance<InMemoryEventListener>(element);

            Assert.IsNotNull(sut);
            Assert.IsInstanceOfType(sut, typeof(InMemoryEventListener));
        }

        [TestMethod]
        public void when_creating_instance_from_element_with_parameters()
        {
            var doc = XDocument.Parse(
               @"<customSink name=""custom"" type=""Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Tests.TestObjects.InMemoryEventListener, Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Tests"">
                    <sources>
                      <eventSource name=""MyCompany""/>
                    </sources>
                    <parameters>
                      <parameter name=""formatter"" type=""Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Tests.TestObjects.MockFormatter, Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Tests""/>
                    </parameters>
                 </customSink>");

            var sut = XmlUtil.CreateInstance<InMemoryEventListener>(doc.Root);

            Assert.IsNotNull(sut);
            Assert.IsInstanceOfType(sut, typeof(InMemoryEventListener));
        }
    }
}
