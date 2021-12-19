using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryUiTests.Pages.MainPage
{
    public partial class MainPage
    {
        public WindowsElement TxtAuthor => _driver.FindElementByAccessibilityId("TxtAuthor");
        public WindowsElement TxtTitle => _driver.FindElementByAccessibilityId("TxtTitle");
        public WindowsElement CmbGenre => _driver.FindElementByAccessibilityId("CmbGenre");
        public WindowsElement CmbAllGenres => _driver.FindElementByClassName("ComboBox");
        public WindowsElement BtnOpenCalendar => _driver.FindElementByAccessibilityId("PART_Button");
        public WindowsElement TxtDate => _driver.FindElementByAccessibilityId("PART_TextBox");
        public WindowsElement LblCalendarDay => _driver.FindElementByClassName("CalendarDayButton");
        public WindowsElement TxtInfo => _driver.FindElementByAccessibilityId("TxtInfo");
        public WindowsElement BtnImage => _driver.FindElementByAccessibilityId("BtnImage");
        public WindowsElement BtnAddBook => _driver.FindElementByAccessibilityId("BtnAddBook");

    }
}
