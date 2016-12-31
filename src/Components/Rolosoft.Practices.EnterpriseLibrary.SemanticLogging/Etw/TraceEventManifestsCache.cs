﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

namespace Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Etw
{
    using System.IO;
    using Microsoft.Diagnostics.Tracing.Parsers;

    internal class TraceEventManifestsCache
    {
        private const string ManifestExtension = ".manifest.xml";
        private const string ManifestSearchPattern = "*" + ManifestExtension;
        private static readonly object LockObject = new object();
        private static readonly string ManifestsPath = Path.Combine(Path.GetTempPath(), "7D2611AE-6432-4639-8B91-3E46EB56CADF");
        private readonly DynamicTraceEventParser parser;

        public TraceEventManifestsCache(DynamicTraceEventParser parser)
        {
            this.parser = parser;
        }

        public void Read()
        {
            lock (LockObject)
            {
                if (Directory.Exists(ManifestsPath))
                {
                    this.parser.ReadAllManifests(ManifestsPath);
                }
            }
        }

        public void Write()
        {
            lock (LockObject)
            {
                this.parser.WriteAllManifests(ManifestsPath);
            }
        }

        public static void Clear()
        {
            lock (LockObject)
            {
                if (Directory.Exists(ManifestsPath))
                {
                    Directory.Delete(ManifestsPath, true);
                }
            }
        }
    }
}
