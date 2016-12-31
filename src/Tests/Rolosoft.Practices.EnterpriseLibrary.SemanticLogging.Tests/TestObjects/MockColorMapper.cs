// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Diagnostics.Tracing;
using Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Formatters;

namespace Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Tests.TestObjects
{
    public class MockColorMapper : IConsoleColorMapper
    {
        public MockColorMapper()
        {
            Instance = this;
        }

        public const ConsoleColor Error = ConsoleColor.DarkRed;

        public ConsoleColor? Color { get; private set; }

        public ConsoleColor? Map(EventLevel eventLevel)
        {
            if (eventLevel == EventLevel.Error)
            {
                this.Color = Error;
            }
            return this.Color;
        }

        public static MockColorMapper Instance { get; private set; }
    }
}
