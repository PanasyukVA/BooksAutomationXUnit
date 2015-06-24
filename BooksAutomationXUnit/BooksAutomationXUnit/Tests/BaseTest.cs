using System;
using BooksAutomationXUnit.Utilities;

namespace BooksAutomationXUnit.Tests
{
    class BaseTest : IDisposable
    {
        private TestFixture fixture;

        public BaseTest(TestFixture fixture) 
        {
            this.fixture = fixture;
        }

        public void Dispose()
        {
            fixture.Pages.booksPage.ConfirmationResult();
            fixture.driver.Manage().Cookies.DeleteAllCookies();
        }
    }
}
