﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rolosoft.Practices.EnterpriseLibrary.SemanticLogging {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SemanticLoggingEventSourceResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SemanticLoggingEventSourceResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.SemanticLoggingEventSourceRe" +
                            "sources", typeof(SemanticLoggingEventSourceResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The buffering capacity of {0} events for the sink {1} has been reached. New entries will be discarded..
        /// </summary>
        internal static string event_BufferedEventPublisherCapacityOverloaded {
            get {
                return ResourceManager.GetString("event_BufferedEventPublisherCapacityOverloaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The buffering capacity for the sink {0} was restored..
        /// </summary>
        internal static string event_BufferedEventPublisherCapacityRestored {
            get {
                return ResourceManager.GetString("event_BufferedEventPublisherCapacityRestored", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} events could not be sent to the sink {1} and will be lost..
        /// </summary>
        internal static string event_BufferedEventPublisherEventsLostWhileDisposing {
            get {
                return ResourceManager.GetString("event_BufferedEventPublisherEventsLostWhileDisposing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unobserved fault was detected in the sink {0}. Message: {1}.
        /// </summary>
        internal static string event_BufferedEventPublisherUnobservedTaskFault {
            get {
                return ResourceManager.GetString("event_BufferedEventPublisherUnobservedTaskFault", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The console sink failed to write an event. Message: {0}.
        /// </summary>
        internal static string event_ConsoleSinkWriteFailed {
            get {
                return ResourceManager.GetString("event_ConsoleSinkWriteFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unhandled fault in a custom formatter. Message: {0}.
        /// </summary>
        internal static string event_CustomFormatterUnhandledFault {
            get {
                return ResourceManager.GetString("event_CustomFormatterUnhandledFault", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unhandled fault in a custom sink. Message: {0}.
        /// </summary>
        internal static string event_CustomSinkUnhandledFault {
            get {
                return ResourceManager.GetString("event_CustomSinkUnhandledFault", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A database sink failed to publish events. Message: {0}.
        /// </summary>
        internal static string event_DatabaseSinkPublishEventsFailed {
            get {
                return ResourceManager.GetString("event_DatabaseSinkPublishEventsFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A database sink discarded {0} events due to failures while attempting to publish a batch..
        /// </summary>
        internal static string event_DatabaseSinkPublishEventsFailedAndDiscardsEntries {
            get {
                return ResourceManager.GetString("event_DatabaseSinkPublishEventsFailedAndDiscardsEntries", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A database sink discarded an event with index {1} due to a failure while attempting to publish a batch. Message: {0}.
        /// </summary>
        internal static string event_DatabaseSinkPublishEventsFailedAndDiscardSingleEntry {
            get {
                return ResourceManager.GetString("event_DatabaseSinkPublishEventsFailedAndDiscardSingleEntry", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A transient fault occurred in a database sink. Message: {0}.
        /// </summary>
        internal static string event_DatabaseSinkPublishEventsTransientError {
            get {
                return ResourceManager.GetString("event_DatabaseSinkPublishEventsTransientError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The JSON writer failed to handle an event. Message: {0}.
        /// </summary>
        internal static string event_EventEntryJsonWriterFailed {
            get {
                return ResourceManager.GetString("event_EventEntryJsonWriterFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The payload for an event could not be serialized. Message: {0}.
        /// </summary>
        internal static string event_EventEntrySerializePayloadFailed {
            get {
                return ResourceManager.GetString("event_EventEntrySerializePayloadFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The text formatter failed to format an event. Message: {0}.
        /// </summary>
        internal static string event_EventEntryTextWriterFailed {
            get {
                return ResourceManager.GetString("event_EventEntryTextWriterFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The XML formatter failed to format an event. Message: {0}.
        /// </summary>
        internal static string event_EventEntryXmlWriterFailed {
            get {
                return ResourceManager.GetString("event_EventEntryXmlWriterFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A flat file sink failed to write an event. Message: {0}.
        /// </summary>
        internal static string event_FlatFileSinkWriteFailed {
            get {
                return ResourceManager.GetString("event_FlatFileSinkWriteFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Formatting an entry failed. Message: {0}.
        /// </summary>
        internal static string event_FormatEntryAsStringFailed {
            get {
                return ResourceManager.GetString("event_FormatEntryAsStringFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mapping the event level {0} to a color failed. Message: {0}.
        /// </summary>
        internal static string event_MapEntryLevelToColorFailed {
            get {
                return ResourceManager.GetString("event_MapEntryLevelToColorFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parsing the manifest for provider &apos;{0}&apos; to handle the event with ID {1} failed. Message: {2}.
        /// </summary>
        internal static string event_ParsingEventSourceManifestFailed {
            get {
                return ResourceManager.GetString("event_ParsingEventSourceManifestFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A rolling flat file sink failed to write an event. Message: {0}.
        /// </summary>
        internal static string event_RollingFlatFileSinkWriteFailed {
            get {
                return ResourceManager.GetString("event_RollingFlatFileSinkWriteFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration changed for the element &apos;{0}&apos;. Message: {1}.
        /// </summary>
        internal static string event_TraceEventServiceConfigurationChanged {
            get {
                return ResourceManager.GetString("event_TraceEventServiceConfigurationChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A fault was detected while processing the configuration for the element &apos;{0}&apos;. Message: {1}.
        /// </summary>
        internal static string event_TraceEventServiceConfigurationFault {
            get {
                return ResourceManager.GetString("event_TraceEventServiceConfigurationFault", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A fault was detected while loading the configuration file. Message: {0}.
        /// </summary>
        internal static string event_TraceEventServiceConfigurationFileLoadFault {
            get {
                return ResourceManager.GetString("event_TraceEventServiceConfigurationFileLoadFault", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A fault was detected while shutting down the configured listeners. Message: {0}.
        /// </summary>
        internal static string event_TraceEventServiceConfigurationShutdownFault {
            get {
                return ResourceManager.GetString("event_TraceEventServiceConfigurationShutdownFault", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration was partially successfully loaded. Check logs for further error details..
        /// </summary>
        internal static string event_TraceEventServiceConfigurationWithFaults {
            get {
                return ResourceManager.GetString("event_TraceEventServiceConfigurationWithFaults", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Some events will be lost because of buffer overruns or schema synchronization delays in trace session: {0}..
        /// </summary>
        internal static string event_TraceEventServiceEventsWillBeLost {
            get {
                return ResourceManager.GetString("event_TraceEventServiceEventsWillBeLost", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An improperly generated manifest was received for provider {0}. Message: {1}.
        /// </summary>
        internal static string event_TraceEventServiceManifestGenerationFault {
            get {
                return ResourceManager.GetString("event_TraceEventServiceManifestGenerationFault", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The loss of {1} events was detected in trace session &apos;{0}&apos;..
        /// </summary>
        internal static string event_TraceEventServiceProcessEventsLost {
            get {
                return ResourceManager.GetString("event_TraceEventServiceProcessEventsLost", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unhandled fault was detected in the processing task for the trace session &apos;{0}&apos;. Message: {1}.
        /// </summary>
        internal static string event_TraceEventServiceProcessTaskFault {
            get {
                return ResourceManager.GetString("event_TraceEventServiceProcessTaskFault", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The trace session with the name &apos;{0}&apos; was removed..
        /// </summary>
        internal static string event_TraceEventServiceSessionRemoved {
            get {
                return ResourceManager.GetString("event_TraceEventServiceSessionRemoved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unhandled exception occurred for the trace session &apos;{0}&apos;. Message: {1}.
        /// </summary>
        internal static string event_TraceEventServiceSinkUnhandledFault {
            get {
                return ResourceManager.GetString("event_TraceEventServiceSinkUnhandledFault", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A Microsoft Azure Table sink failed to create an entity. Message: {0}.
        /// </summary>
        internal static string event_WindowsAzureTableSinkEntityCreationFailed {
            get {
                return ResourceManager.GetString("event_WindowsAzureTableSinkEntityCreationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A Microsoft Azure Table sink failed to write a batch of events. Message: {0}.
        /// </summary>
        internal static string event_WindowsAzureTableSinkPublishEventsFailed {
            get {
                return ResourceManager.GetString("event_WindowsAzureTableSinkPublishEventsFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A Microsoft Azure Table sink discarded {0} events due to failures while attempting to publish a batch..
        /// </summary>
        internal static string event_WindowsAzureTableSinkPublishEventsFailedAndDiscardsEntries {
            get {
                return ResourceManager.GetString("event_WindowsAzureTableSinkPublishEventsFailedAndDiscardsEntries", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A Microsoft Azure Table sink failed to create a table. Message: {0}.
        /// </summary>
        internal static string event_WindowsAzureTableSinkTableCreationFailed {
            get {
                return ResourceManager.GetString("event_WindowsAzureTableSinkTableCreationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A transient fault occurred in a Microsoft Azure Table sink. Message: {0}.
        /// </summary>
        internal static string event_WindowsAzureTableSinkTransientError {
            get {
                return ResourceManager.GetString("event_WindowsAzureTableSinkTransientError", resourceCulture);
            }
        }
    }
}
