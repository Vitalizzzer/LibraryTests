using OpenQA.Selenium.Appium.Windows;

namespace LibraryTests.Pages.MainPage
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
        public WindowsElement DataGrid => _driver.FindElementByAccessibilityId("DataGrid");
        public WindowsElement MenuEdit => _driver.FindElementByAccessibilityId("EditMenuItem");
        public WindowsElement MenuDelete => _driver.FindElementByAccessibilityId("DeleteMenuItem");
        public WindowsElement MenuBrowse => _driver.FindElementByAccessibilityId("BrowseMenuItem");
        public WindowsElement BtnConfirmDeletion => _driver.FindElementByAccessibilityId("6");
        public WindowsElement BtnCancelDeletion => _driver.FindElementByAccessibilityId("7");

    }
}
