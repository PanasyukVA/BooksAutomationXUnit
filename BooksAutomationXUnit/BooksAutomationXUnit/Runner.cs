using Xunit;
using BooksAutomationXUnit.Utilities;
using BooksAutomationXUnit.Tests.Smoke;
using BooksAutomationXUnit.Tests.Functional;

namespace BooksAutomationXUnit
{
    public class Runner : IClassFixture<TestFixture>
    {
        TestFixture fixture;
        
        public Runner(TestFixture fixture)
        {
            this.fixture = fixture;
        }

        #region Smoke Tests
        [Fact, Trait("TestCategory", "SmokeTests")]
        public void LoadLoginPageST()
        {
            using (LoadLoginPageClass loadLoginPage = new LoadLoginPageClass(fixture))
            {
                loadLoginPage.LoadLoginPage();
            }
        }

        [Fact, Trait("TestCategory", "SmokeTests")]
        public void LoadMainPageST()
        {
            using (LoadMainPageClass loadMainPage = new LoadMainPageClass(fixture))
            {
                loadMainPage.LoadMainPage();
            }
        }

        [Fact, Trait("TestCategory", "SmokeTests")]
        public void LogInOnSite()
        {
            using (LogInOnSiteClass logInOnSite = new LogInOnSiteClass(fixture))
            {
                logInOnSite.LogInOnSite();
            }
        }

        #endregion

        #region Functional Tests
        [Fact, Trait("TestCategory", "FunctionalTests")]
        public void AddAuthorFT()
        {
            using (AddAuthorClass addAuthor = new AddAuthorClass(fixture))
            {
                addAuthor.AddAuthor();
            }
        }

        [Fact, Trait("TestCategory", "FunctionalTests")]
        public void AddBookFT()
        {
            using (AddBookClass addBook = new AddBookClass(fixture))
            {
                addBook.AddBook();
            }
        }

        [Fact, Trait("TestCategory", "FunctionalTests")]
        public void EditAuthorFT()
        {
            using (EditAuthorClass editAuthor = new EditAuthorClass(fixture))
            {
                editAuthor.EditAuthor();
            }
        }

        [Fact, Trait("TestCategory", "FunctionalTests")]
        public void EditBookFT()
        {
            using (EditBookClass editBook = new EditBookClass(fixture))
            {
                editBook.EditBook();
            }
        }

        #endregion
    }
}
