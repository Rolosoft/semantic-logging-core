// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.Practices.EnterpriseLibrary.SemanticLogging.Tests.TestSupport
{
#if !DEBUG
// Do not run on build server
    [Ignore]
#endif
    [TestClass]
    public abstract class ContextBase
    {
        [TestInitialize]
        public void Initialize()
        {
            this.Given();
            this.When();
        }

        [TestCleanup]
        public void Cleanup()
        {
            this.OnCleanup();
        }

        protected virtual void Given()
        {
        }

        protected virtual void When()
        {
        }

        protected virtual void OnCleanup()
        {
        }
    }
}
