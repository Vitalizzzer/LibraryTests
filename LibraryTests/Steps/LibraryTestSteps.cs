using LibraryTests.Driver;
using LibraryTests.Pages.MainPage;
using OpenQA.Selenium.Appium.Windows;
using TechTalk.SpecFlow;

namespace LibraryUiTests.Steps
{
    [Binding]
    public class LibraryTestSteps : AppiumDriver
    {

        private readonly ScenarioContext scenarioContext;
        private MainPage _mainPage;
        private WindowsDriver<WindowsElement> _driver;

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
            _mainPage.EnterAuthorName(author);           
        }

        [Given(@"book title (.*)")]
        public void EnterBookTitle(string title)
        {
            _mainPage.EnterTitleName(title);
        }

        [Given(@"choose book genre (.*)")]
        public void ChooseBookGenre(string genre)
        {
            _mainPage.ChooseGenre(genre);
        }

        [Given(@"choose date")]
        public void ChooseDate()
        {
            _mainPage.ChooseDate();
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
        public void CheckBookAppearsInDb()
        {

        }

    }
}
