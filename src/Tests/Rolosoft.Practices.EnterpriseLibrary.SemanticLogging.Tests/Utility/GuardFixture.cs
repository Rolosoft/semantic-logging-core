// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using Microsoft.Practices.EnterpriseLibrary.SemanticLogging.Tests.TestSupport;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Utility;

namespace Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Tests.Utility
{

#if !DEBUG
// Do not run on build server
    [Ignore]
#endif
    [TestClass]
    public class GuardFixture
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowOnInvalidDateTimeFormat()
        {
            Guard.ValidDateTimeFormat("0", "dtf");
        }

        [TestMethod]
        public void CheckForInvalidFileNameChars()
        {
            AssertEx.Throws<ArgumentException>(() => Guard.ValidateTimestampPattern("MM/dd/yyyy", "timestampPattern"));
            AssertEx.Throws<ArgumentException>(() => Guard.ValidateTimestampPattern("MM:dd:yyyy", "timestampPattern"));
        }
    }
}
