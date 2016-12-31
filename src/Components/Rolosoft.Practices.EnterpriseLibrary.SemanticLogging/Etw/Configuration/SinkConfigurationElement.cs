// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

namespace Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Etw.Configuration
{
    using System;
    using System.Collections.Generic;
    using SemanticLogging;

    internal class SinkConfigurationElement
    {
        internal string Name { get; set; }

        internal Lazy<IObserver<EventEntry>> SinkPromise { get; set; }

        internal IEnumerable<EventSourceElement> EventSources { get; set; }

        internal string SinkConfiguration { get; set; }
    }
}
