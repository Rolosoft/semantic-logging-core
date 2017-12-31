﻿using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using Microsoft.Practices.EnterpriseLibrary.SemanticLogging.Tests.TestObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Tests.UsingEventListener
{

#if !DEBUG
// Do not run on build server
    [Ignore]
#endif
    [TestClass]
    public class ObservableEventListenerFixturePartialTrust
    {
        [TestMethod]
        public void CanGetThreadIdAndProcessidOnFullTrust()
        {
            var evidence = new Evidence();
            evidence.AddHostEvidence(new Zone(SecurityZone.MyComputer));
            var permissionSet = SecurityManager.GetStandardSandbox(evidence);

            var appDomain =
                AppDomain.CreateDomain(
                    "full trust",
                    evidence,
                    new AppDomainSetup { ApplicationBase = Environment.CurrentDirectory },
                    permissionSet);

            try
            {
                var tester = (ProcessIdAndThreadIdTester)appDomain
                    .CreateInstanceAndUnwrap(
                        typeof(ProcessIdAndThreadIdTester).Assembly.GetName().Name,
                        typeof(ProcessIdAndThreadIdTester).FullName);

                var result = tester.GetProcessIdAndThreadIdThoughEvent();

                Assert.AreEqual(Process.GetCurrentProcess().Id, result.Item1);
                Assert.AreNotEqual(0, result.Item2);
            }
            finally
            {
                AppDomain.Unload(appDomain);
            }
        }

#if !EVENT_SOURCE_PACKAGE
        // Partial trust not supported with the NuGet package
        [TestMethod]
        public void CannotGetThreadIdAndProcessidOnPartialTrust()
        {
            var evidence = new Evidence();
            evidence.AddHostEvidence(new Zone(SecurityZone.Intranet));
            var permissionSet = SecurityManager.GetStandardSandbox(evidence);

            var appDomain =
                AppDomain.CreateDomain(
                    "partial trust",
                    evidence,
                    new AppDomainSetup { ApplicationBase = Environment.CurrentDirectory },
                    permissionSet);

            try
            {
                var tester = (ProcessIdAndThreadIdTester)appDomain
                    .CreateInstanceAndUnwrap(
                        typeof(ProcessIdAndThreadIdTester).Assembly.GetName().Name,
                        typeof(ProcessIdAndThreadIdTester).FullName);

                var result = tester.GetProcessIdAndThreadIdThoughEvent();

                Assert.AreEqual(0, result.Item1);
                Assert.AreEqual(0, result.Item2);
            }
            finally
            {
                AppDomain.Unload(appDomain);
            }
        }

        [Ignore] // Unit test not working from original source code. ROC 12/31/16
        [TestMethod]
        public void CannotGetThreadIdAndProcessidOnPartialTrustIfFullyTrusted()
        {
            var slabAssemblyName = typeof(EventEntry).Assembly.GetName();
            if (slabAssemblyName.GetPublicKeyToken().Length == 0)
            {
                Assert.Inconclusive("Can only be run if assemblies are signed");
            }

            var evidence = new Evidence();
            evidence.AddHostEvidence(new Zone(SecurityZone.Intranet));
            var permissionSet = SecurityManager.GetStandardSandbox(evidence);

            var appDomain =
                AppDomain.CreateDomain(
                    "partial trust",
                    evidence,
                    new AppDomainSetup { ApplicationBase = Environment.CurrentDirectory },
                    permissionSet,
                    new StrongName(new StrongNamePublicKeyBlob(slabAssemblyName.GetPublicKey()), slabAssemblyName.Name, slabAssemblyName.Version));

            try
            {
                var tester = (ProcessIdAndThreadIdTester)appDomain
                    .CreateInstanceAndUnwrap(
                        typeof(ProcessIdAndThreadIdTester).Assembly.GetName().Name,
                        typeof(ProcessIdAndThreadIdTester).FullName);

                var result = tester.GetProcessIdAndThreadIdThoughEvent();

                Assert.AreEqual(0, result.Item1);
                Assert.AreEqual(0, result.Item2);
            }
            finally
            {
                AppDomain.Unload(appDomain);
            }
        }
#endif
    }

    public class ProcessIdAndThreadIdTester : MarshalByRefObject
    {
        public Tuple<int, int> GetProcessIdAndThreadIdThoughEvent()
        {
            using (var listener = new ObservableEventListener())
            {
                var observer = new SimpleObserver<EventEntry>();

                listener.EnableEvents(TestEventSource.Log, EventLevel.Informational, EventKeywords.None);
                listener.Subscribe(observer);

                TestEventSource.Log.Informational("some info");

                EventEntry entry;
                if (observer.Elements.TryTake(out entry, TimeSpan.FromSeconds(10)))
                {
                    return Tuple.Create(entry.ProcessId, entry.ThreadId);
                }

                throw new TimeoutException("timed out waiting for envent");
            }
        }

        private class SimpleObserver<T> : IObserver<T>
        {
            private readonly BlockingCollection<T> elements = new BlockingCollection<T>();

            public void OnCompleted()
            {
                this.elements.CompleteAdding();
            }

            public void OnError(Exception error)
            {
                this.elements.CompleteAdding();
            }

            public void OnNext(T value)
            {
                this.elements.Add(value);
            }

            public BlockingCollection<T> Elements
            {
                get { return this.elements; }
            }
        }
    }
}
