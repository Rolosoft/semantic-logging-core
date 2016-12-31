// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

namespace Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Configuration
{
    using System;
    using System.Xml.Linq;
    using Observable;
    using SemanticLogging;
    using Utility;

    internal class CustomSinkElement : ISinkElement
    {
        private readonly XName sinkName = XName.Get("customSink", Constants.Namespace);

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Justification = "Validated with Guard class")]
        public bool CanCreateSink(XElement element)
        {
            Guard.ArgumentNotNull(element, "element");

            return element.Name == this.sinkName;
        }

        public IObserver<EventEntry> CreateSink(XElement element)
        {
            Guard.ArgumentNotNull(element, "element");

            var subject = new EventEntrySubject();
            var sink = XmlUtil.CreateInstance<IObserver<EventEntry>>(element);
            subject.Subscribe(sink);
            return subject;
        }
    }
}
