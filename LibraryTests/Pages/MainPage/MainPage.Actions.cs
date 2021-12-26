using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Interactions;
using System.Collections.ObjectModel;

namespace LibraryTests.Pages.MainPage
{
    public partial class MainPage
    {
        private readonly WindowsDriver<WindowsElement> _driver;
        public MainPage(WindowsDriver<WindowsElement> driver) => _driver = driver;

        public void EnterAuthorName(string authorName)
        {
            TxtAuthor.SendKeys(authorName);
        }

        public void EnterTitleName(string titleName)
        {
            TxtTitle.SendKeys(titleName);
        }

        public void ChooseGenre(string genreName)
        {
            CmbGenre.Click();
            WindowsElement cmbItems = CmbAllGenres;
            cmbItems.FindElementByName(genreName).Click();
        }

        public string ChooseDate()
        {
            BtnOpenCalendar.Click();
            LblCalendarDay.Click();
            var text = TxtDate.Text;
            return text;
        }

        public void EnterInfo(string info)
        {
            TxtInfo.SendKeys(info);
        }

        public void OpenChooseImageWindow()
        {
            BtnImage.Click();
        }
        public void ClickAddBook()
        {
            BtnAddBook.Click();
        }
        public ReadOnlyCollection<AppiumWebElement> GetRowsFromDataGrid()
        {
            var rowsCollection = DataGrid.FindElementsByClassName("DataGridRow");
            return rowsCollection;
        }

        public ReadOnlyCollection<AppiumWebElement> GetCellsFromDataGridRow (AppiumWebElement row)
        {
            var cellsCollection = row.FindElementsByClassName("DataGridCell");
            return cellsCollection;
        }

        public void RightClickGridRow(AppiumWebElement element)
        {
            Actions actions = new Actions(_driver);
            actions.ContextClick(element).Perform();          
        }

        public void ClickEditMenuItem()
        {
            MenuEdit.Click();
        }

        public void ClickDeleteMenuItem()
        {
            MenuDelete.Click();
        }

        public void ClickBrowseMenuItem()
        {
            MenuBrowse.Click();
        }

        public void ConfirmDeletion()
        {
            BtnConfirmDeletion.Click();
        }
    }
}
