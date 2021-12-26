using LibraryTests.Driver;
using LibraryTests.Pages.MainPage;
using log4net;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Windows;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace LibraryTests.Steps
{
    [Binding]
    public class LibraryTestSteps : AppiumDriver
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private readonly ScenarioContext scenarioContext;
        private MainPage _mainPage;
        private WindowsDriver<WindowsElement> _driver;
        const string FMT = "dd.MM.yyyy";

        public LibraryTestSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void TestInit()
        {
            _driver = InitAppiumDriver();
            _mainPage = new MainPage(driver);
        }

        [Given(@"author name (.*)")]
        public void EnterAuthorName(string author)
        {
            scenarioContext.Add("author", author);
            _mainPage.EnterAuthorName(author);
        }

        [Given(@"book title (.*)")]
        public void EnterBookTitle(string title)
        {
            scenarioContext.Add("title", title);
            _mainPage.EnterTitleName(title);
        }

        [Given(@"choose book genre (.*)")]
        public void ChooseBookGenre(string genre)
        {
            scenarioContext.Add("genre", genre);
            _mainPage.ChooseGenre(genre);
        }

        [Given(@"choose date")]
        public void ChooseDate()
        {
            var date = _mainPage.ChooseDate();
            scenarioContext.Add("date", date);
        }

        [Given(@"enter info (.*)")]
        public void EnterInfo(string info)
        {
            _mainPage.EnterInfo(info);
        }

        [When(@"click (.*) button")]
        public void ClickButton(string buttonName)
        {
            _mainPage.ClickAddBook();
        }

        [Then(@"the book appears in the db")]
        public void VerifyBookAppearsInDb()
        {
            bool isPresentList = false;
            var booksPage =  GetBooksFromPage();
            var author = scenarioContext.Get<string>("author");
            var title = scenarioContext.Get<string>("title");
            var genre = scenarioContext.Get<string>("genre");
            var date = scenarioContext.Get<string>("date");

            foreach (var book in booksPage)
            {
                if (book.Value.Author.Equals(author))
                {
                    isPresentList = true;
                    Assert.AreEqual(title, book.Value.Title);
                    Assert.AreEqual(genre, book.Value.GenreName);
                    Assert.AreEqual(date, book.Value.Date);                   
                }                
            }

            if(isPresentList != true)
            {
                Assert.Fail("Expected book is ot found: Author: " + author + " , Title: " + title + " , Genre: " + genre);
            }
        }

        [Then(@"book is absent")]
        public void VerifyBookIsAbsent()
        {
            var booksPage = GetBooksFromPage();
            var author = scenarioContext.Get<string>("author");
            var title = scenarioContext.Get<string>("title");

            foreach (var book in booksPage)
            {
                if (book.Value.Author.Equals(author) && book.Value.Title.Equals(title))
                {
                    Assert.Fail("Book with Author: '" + book.Value.Author + "' and Title: '" + book.Value.Title + "' is unexpectedly present");
                }
            }

            Assert.Pass();
        }

        [When("delete book by (.*)")]
        public void DeleteBookByAuthor(string authorName)
        {
            var rows = _mainPage.GetRowsFromDataGrid();

            foreach (var row in rows)
            {
                var cells = _mainPage.GetCellsFromDataGridRow(row);

                if (cells[0].Text.Equals(authorName)){
                    _mainPage.RightClickGridRow(cells[0]);
                    _mainPage.ClickDeleteMenuItem();
                    _mainPage.ConfirmDeletion();
                    break;
                }
            }           
        }

        private Dictionary<int, Book> GetBooksFromPage()
        {
            Dictionary<int, Book> bookDic = new Dictionary<int, Book>();
            int index = 0;
            var rows = _mainPage.GetRowsFromDataGrid();
         
            foreach (var row in rows)
            {
                var cells = _mainPage.GetCellsFromDataGridRow(row);

                var author = cells[0].Text;
                var title = cells[1].Text;
                var genre = cells[2].Text;
                var date = cells[3].Text;

                Book book = new Book(author, title, genre, date, "", null);
                bookDic.Add(index, book);
                index++;
            }
            return bookDic;
        }
    }
}
