﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

namespace Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Etw.Configuration
{
    using System.Xml.Linq;
    using SemanticLogging.Configuration;

    internal class TraceEventServiceElement
    {
        internal TraceEventServiceElement()
        {
            this.SessionNamePrefix = Constants.DefaultSessionNamePrefix;
        }

        internal string SessionNamePrefix { get; set; }

        internal static TraceEventServiceElement Read(XElement element)
        {
            var instance = new TraceEventServiceElement();

            var snpAttr = (string)element.Attribute("sessionNamePrefix");
            if (!string.IsNullOrWhiteSpace(snpAttr))
            {
                instance.SessionNamePrefix = snpAttr;
            }

            return instance;
        }
    }
}
