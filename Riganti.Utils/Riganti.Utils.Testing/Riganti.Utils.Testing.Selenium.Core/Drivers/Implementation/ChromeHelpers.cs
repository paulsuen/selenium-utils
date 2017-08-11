﻿using System;
using OpenQA.Selenium.Chrome;
using Riganti.Utils.Testing.Selenium.Core.Factories;

namespace Riganti.Utils.Testing.Selenium.Core.Drivers.Implementation
{
    public static class ChromeHelpers
    {

        public static ChromeDriver CreateChromeDriver(LocalWebBrowserFactory factory)
        {
            var options = new ChromeOptions();
            options.AddArgument("test-type");
            options.AddArgument("disable-popup-blocking");

            if (factory.GetBooleanOption("disableExtensions"))
            {
                options.AddArgument("--disable-extensions");
            }

            return new ChromeDriver(options);
        }

    }
}