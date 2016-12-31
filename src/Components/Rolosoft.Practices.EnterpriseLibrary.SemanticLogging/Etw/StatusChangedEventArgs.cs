// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

namespace Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Etw
{
    using System;
    using Microsoft.Practices.EnterpriseLibrary.SemanticLogging.Etw;

    /// <summary>
    /// Provides data for <see cref="TraceEventService.StatusChanged"/> event.
    /// </summary>
    public class StatusChangedEventArgs : EventArgs
    {
        internal StatusChangedEventArgs(ServiceStatus status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Gets the changed status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public ServiceStatus Status { get; private set; }
    }
}
