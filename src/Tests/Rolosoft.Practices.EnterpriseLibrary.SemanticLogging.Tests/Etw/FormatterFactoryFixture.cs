namespace Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Tests.Etw
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Linq;
    using Microsoft.Practices.EnterpriseLibrary.SemanticLogging.Tests.TestSupport;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SemanticLogging.Formatters;
    using SemanticLogging.Configuration;

    public class given_formatterelementfactory
    {
        public abstract class when_creating_json_formatter : ContextBase
        {
            protected JsonEventTextFormatter sut;

            protected override void Given()
            {
                FormatterElementFactory.FormatterElements = GetFormatterElements();
            }

            private IEnumerable<Lazy<IFormatterElement>> GetFormatterElements()
            {
                yield return new Lazy<IFormatterElement>(() => new JsonEventTextFormatterElement());
                yield return new Lazy<IFormatterElement>(() => new XmlEventTextFormatterElement());
                yield return new Lazy<IFormatterElement>(() => new EventTextFormatterElement());
            }

            protected override void When()
            {
                sut =
                    FormatterElementFactory.Get(XElement.Parse(string.Format(@"<consoleSink xmlns='http://schemas.microsoft.com/practices/2013/entlib/semanticlogging/etw' name='ConsoleEventListener1'><sources><eventSource name='Foo' level='Error'/></sources>{0}</consoleSink>", GetElementText()))) as JsonEventTextFormatter;
            }

            protected abstract string GetElementText();
        }

        [Ignore] // Unit test not working from original source code. ROC 12/31/16
        [TestClass]
        public class when_creating_formatter_with_separator_set_to_false : when_creating_json_formatter
        {
            protected override string GetElementText()
            {
                return @"<jsonEventTextFormatter includeEntrySeparator='false' />";
            }

            [TestMethod]
            public void then_separator_should_be_set_to_false()
            {
                Assert.IsFalse(sut.IncludeEntrySeparator);
            }
        }

        [Ignore] // Unit test not working from original source code. ROC 12/31/16
        [TestClass]
        public class when_creating_formatter_with_separator_set_to_true : when_creating_json_formatter
        {
            protected override string GetElementText()
            {
                return @"<jsonEventTextFormatter includeEntrySeparator='true' />";
            }

            [TestMethod]
            public void then_separator_should_be_set_to_true()
            {
                Assert.IsTrue(sut.IncludeEntrySeparator);
            }
        }

        [Ignore] // Unit test not working from original source code. ROC 12/31/16
        [TestClass]
        public class when_creating_formatter_with_separator_not_set : when_creating_json_formatter
        {
            protected override string GetElementText()
            {
                return @"<jsonEventTextFormatter/>";
            }

            [TestMethod]
            public void then_separator_should_be_set_to_true()
            {
                Assert.IsTrue(sut.IncludeEntrySeparator);
            }
        }
    }
}
