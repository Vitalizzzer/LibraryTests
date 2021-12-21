using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;

namespace LibraryTests.Driver
{
    public class AppiumDriver
    {
        private const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        private const string AppId = @"C:\Users\Laptop\source\repos\Library_ADO\Library\bin\Debug\Library.exe";

        protected static WindowsDriver<WindowsElement> driver;

        public static WindowsDriver<WindowsElement> InitAppiumDriver()
        {
            if (driver == null)
            {       
                AppiumOptions options = new AppiumOptions();
                options.AddAdditionalCapability("app", AppId);
                options.AddAdditionalCapability("deviceName", "WindowsPC");

                driver = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), options);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1.5);
            }

            return driver;
        }

        public static void TearDownAppiumDriver()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
    }
}
