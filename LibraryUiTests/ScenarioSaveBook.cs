using LibraryUiTests.Pages.MainPage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace LibraryUiTests
{
    [TestClass]
    public class ScenarioSaveBook : LibrarySession
    {
        private MainPage _mainPage;
        private WindowsDriver<WindowsElement> _driver;
        // session.FindElementByXPath("//Button[@Name='Equals']").Click();
        // session.FindElementByXPath("//Button[@AutomationId=\"num9Button\"]").Click();
       [TestInitialize]
       public void TestInit()
        {
            _driver = Setup();
            _mainPage = new MainPage(driver);
        }

        [TestCleanup]
        public void TestClean()
        {
            TearDown();
        }


        [TestMethod]
        public void AddBookPossitive()
        {

            _mainPage.EnterAuthorName("Good Author");
            _mainPage.EnterTitleName("Good Title");
            _mainPage.ChooseGenre("Poetry");
            _mainPage.ChooseDate();
            _mainPage.EnterInfo("Amazing book!");
            _mainPage.ClickAddBook();


            //driver.FindElementByAccessibilityId("TxtAuthor").SendKeys("Good Author");
            //driver.FindElementByAccessibilityId("TxtTitle").SendKeys("Good Title");
            //driver.FindElementByAccessibilityId("CmbGenre").Click();
            //WindowsElement cmbItems =  driver.FindElementByClassName("ComboBox");
            //cmbItems.FindElementByName("Poetry").Click();           

            //driver.FindElementByAccessibilityId("PART_Button").Click();
            //driver.FindElementByClassName("CalendarDayButton").Click();
            //// driver.FindElementByAccessibilityId("LblDate").SendKeys("1-Apr-2021");
            //driver.FindElementByAccessibilityId("TxtInfo").SendKeys("Amazing book!");
        }

    }
}
