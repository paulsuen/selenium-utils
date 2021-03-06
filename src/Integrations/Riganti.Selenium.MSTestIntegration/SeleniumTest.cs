﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Riganti.Selenium.Core.Configuration;

namespace Riganti.Selenium.Core
{
    /// <summary>
    /// Represents implementation of base for selenium tests for MSTest. 
    /// </summary>
    public class SeleniumTest : SeleniumTestExecutor
    {

        public TestContext TestContext { get; set; }


        protected override TestSuiteRunner InitializeTestSuiteRunner(SeleniumTestsConfiguration configuration)
        {
            var provider = new TestContextProvider();
            provider.SetContext(TestContext);
            return new TestSuiteRunner(configuration, provider);
        }
        
    }
}