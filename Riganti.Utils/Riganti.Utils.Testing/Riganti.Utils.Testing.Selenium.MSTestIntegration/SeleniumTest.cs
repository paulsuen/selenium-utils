﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Riganti.Utils.Testing.Selenium.Core
{
    /// <summary>
    /// Represents implementation of base for selenium tests for MSTest. 
    /// </summary>
    public class SeleniumTest : SeleniumTestBase
    {
        private ITestContext testContext;

        public override ITestContext Context
        {
            get => testContext ?? (testContext = TestContext?.Wrap());
            set => testContext = value;
        }

        public TestContext TestContext { get; set; }

        [ClassCleanup]
        public override void TotalCleanUp()
        {
            base.TotalCleanUp();
        }
    }
}