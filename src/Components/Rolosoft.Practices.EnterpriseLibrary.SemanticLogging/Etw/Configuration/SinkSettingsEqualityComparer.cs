﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

namespace Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Etw.Configuration
{
    using System.Collections.Generic;
    using SemanticLogging.Utility;

    internal class SinkSettingsEqualityComparer : IEqualityComparer<SinkSettings>
    {
        public bool Equals(SinkSettings x, SinkSettings y)
        {
            if (x == null || y == null)
            {
                return false;
            }

            return x.Name == y.Name;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Justification = "Validated with Guard class")]
        public int GetHashCode(SinkSettings obj)
        {
            Guard.ArgumentNotNull(obj, "obj");

            return obj.Name.GetHashCode();
        }
    }
}
