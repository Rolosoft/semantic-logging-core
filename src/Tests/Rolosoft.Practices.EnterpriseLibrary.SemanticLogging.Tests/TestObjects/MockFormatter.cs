﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Formatters;

namespace Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Tests.TestObjects
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    
    public class MockFormatter : IEventTextFormatter
    {
        public List<EventEntry> WriteEventCalls = new List<EventEntry>();
        public Action<MockFormatter> BeforeWriteEventAction { get; set; }
        public Action<MockFormatter> AfterWriteEventAction { get; set; }

        public void WriteEvent(EventEntry eventData, TextWriter writer)
        {
            this.WriteEventCalls.Add(eventData);

            if (BeforeWriteEventAction != null)
            {
                BeforeWriteEventAction(this);
            }

            if (!string.IsNullOrWhiteSpace(eventData.FormattedMessage)) { writer.Write(eventData.FormattedMessage); }

            writer.Write(string.Join(",", eventData.Payload));

            if (AfterWriteEventAction != null) { AfterWriteEventAction(this); }
        }
    }
}
