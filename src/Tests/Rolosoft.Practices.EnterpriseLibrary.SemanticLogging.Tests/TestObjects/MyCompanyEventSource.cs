﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

namespace Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Tests.TestObjects
{
    using System;
    using System.Diagnostics.Tracing;

    public enum MyColor { Red, Yellow, Blue }

    [EventSource(Name = "MyCompany")]
    public sealed class MyCompanyEventSource : EventSource
    {
        public class Keywords
        {
            public const EventKeywords Page = (EventKeywords)1;
            public const EventKeywords DataBase = (EventKeywords)2;
            public const EventKeywords Diagnostic = (EventKeywords)4;
            public const EventKeywords Perf = (EventKeywords)8;
        }

        public class Tasks
        {
            public const EventTask Page = (EventTask)1;
            public const EventTask DBQuery = (EventTask)2;
        }

        [Event(1, Message = "Application Failure: {0}", Level = EventLevel.Error, Keywords = Keywords.Diagnostic)]
        public void Failure(string message) { WriteEvent(1, message); }

        [Event(2, Message = "Starting up.", Keywords = Keywords.Perf, Level = EventLevel.Informational)]
        public void Startup() { WriteEvent(2); }

        [Event(3, Message = "loading page {1} activityID={0}", Opcode = EventOpcode.Start,
            Task = Tasks.Page, Keywords = Keywords.Page, Level = EventLevel.Informational)]
        public void PageStart(int id, string url) { if (IsEnabled()) { WriteEvent(3, id, url); } }

        [Event(4, Opcode = EventOpcode.Stop, Task = Tasks.Page, Keywords = Keywords.Page, Level = EventLevel.Informational)]
        public void PageStop(int id) { if (IsEnabled()) { WriteEvent(4, id); } }

        [Event(5, Opcode = EventOpcode.Start, Task = Tasks.DBQuery, Keywords = Keywords.DataBase, Level = EventLevel.Informational)]
        public void DBQueryStart(string sqlQuery) { WriteEvent(5, sqlQuery); }

        [Event(6, Opcode = EventOpcode.Stop, Task = Tasks.DBQuery, Keywords = Keywords.DataBase, Level = EventLevel.Informational)]
        public void DBQueryStop() { WriteEvent(6); }

        [Event(7, Level = EventLevel.Verbose, Keywords = Keywords.DataBase)]
        public void Mark(int id) { if (IsEnabled()) { WriteEvent(7, id); } }

        [Event(8)]
        public void LogColor(MyColor color) { WriteEvent(8, (int)color); }

#if !EVENT_SOURCE_PACKAGE
        // This will be invalid in new versions of EventSource - if you have an opcode you must have a task
        [Event(9, Opcode = EventOpcode.Start)]
        public void WithOpcodeAndNoTaskSpecfied(int arg1) { WriteEvent(9, arg1); }
#endif

        [Event(10, Keywords = Keywords.DataBase | Keywords.Perf)]
        public void MultipleKeywords(int arg1) { WriteEvent(10, arg1); }

        [Event(11, Task = Tasks.Page, Opcode = EventOpcode.Send)]
        public void WithRelatedActivityId(Guid relatedActivityId) { /*System.Diagnostics.Tracing.EventSource.WriteEventWithRelatedActivityId(11, relatedActivityId);*/ }

        public static readonly MyCompanyEventSource Log = new MyCompanyEventSource();

        public MyCompanyEventSource()
        {
        }

        protected override void OnEventCommand(EventCommandEventArgs command)
        {
            base.OnEventCommand(command);
        }
    }
}
