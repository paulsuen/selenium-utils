﻿using Riganti.Selenium.Core.Configuration;
using Riganti.Selenium.xUnitIntegration;
using Riganti.Selenium.Core;
using Xunit.Abstractions;

namespace Riganti.Selenium.Core
{
    /// <summary>
    /// Represents implementation of base for selenium tests for MSTest. 
    /// </summary>
    public abstract class SeleniumTest : SeleniumTestExecutor
    {
        public ITestOutputHelper TestOutput { get; set; }

        public SeleniumTest(ITestOutputHelper output)
        {
            TestOutput = output;
        }


        protected override TestSuiteRunner InitializeTestSuiteRunner(SeleniumTestsConfiguration configuration)
        {
            var provider = new TestContextProvider();
            provider.SetContext(TestOutput);
            return new XunitTestSuiteRunner(configuration, provider);
        }

    }
}