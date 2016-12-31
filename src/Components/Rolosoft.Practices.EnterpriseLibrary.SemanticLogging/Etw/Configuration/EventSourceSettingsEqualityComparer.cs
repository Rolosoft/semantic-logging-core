// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

namespace Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Etw.Configuration
{
    using System.Collections.Generic;
    using System.Linq;
    using SemanticLogging.Utility;

    internal class EventSourceSettingsEqualityComparer : IEqualityComparer<EventSourceSettings>
    {
        private readonly bool nameOnly;

        public EventSourceSettingsEqualityComparer(bool nameOnly = false)
        {
            this.nameOnly = nameOnly;
        }

        public bool Equals(EventSourceSettings x, EventSourceSettings y)
        {
            if (x == null || y == null)
            {
                return false;
            }

            return x.Name == y.Name
                && (this.nameOnly
                    || (x.Level == y.Level
                        && x.MatchAnyKeyword == y.MatchAnyKeyword
                        && x.Arguments.SequenceEqual(y.Arguments)
                        && x.ProcessNamesToFilter.SequenceEqual(y.ProcessNamesToFilter)));
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Justification = "Validated with Guard class")]
        public int GetHashCode(EventSourceSettings obj)
        {
            Guard.ArgumentNotNull(obj, "obj");

            if (this.nameOnly)
            {
                return obj.Name.GetHashCode();
            }

            return obj.Name.GetHashCode() ^ (int)obj.Level ^ unchecked((int)obj.MatchAnyKeyword);
        }
    }
}
