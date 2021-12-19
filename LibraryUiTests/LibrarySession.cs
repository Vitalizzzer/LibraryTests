using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;

namespace LibraryUiTests
{
    
    public class LibrarySession
    {
        // Note: append /wd/hub to the URL if you're directing the test at Appium
        private const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        private const string AppId = @"C:\Users\Laptop\source\repos\Library_ADO\Library\bin\Debug\Library.exe";

        protected static WindowsDriver<WindowsElement> driver;

        public static WindowsDriver<WindowsElement> Setup()
        {
            // Launch Calculator application if it is not yet launched
            if (driver == null)
            {               
                // Create a new session to bring up an instance of the Calculator application           
                AppiumOptions options = new AppiumOptions();
                options.AddAdditionalCapability("app", AppId);
                options.AddAdditionalCapability("deviceName", "WindowsPC");

                driver = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), options);
                Assert.IsNotNull(driver);

                // Set implicit timeout to 1.5 seconds to make element search to retry every 500 ms for at most three times
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1.5);
            }

            return driver;
        }

        public static void TearDown()
        {
            // Close the application and delete the session
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
    }
}
