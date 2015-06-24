using System;
using BooksAutomationXUnit.Utilities;
using Xunit;

namespace BooksAutomationXUnit.Tests.Functional
{
    class AddAuthorClass : BaseTest
    {
        private TestFixture fixture;

        public AddAuthorClass(TestFixture fixture) 
            : base(fixture)
        {
            this.fixture = fixture;
        }

        public void AddAuthor()
        {
            // Arrange
            bool actualResult;

            // Act
            fixture.Pages.loginPage.GetPage();
            fixture.Pages.loginPage.Login(fixture.config.Books_UserEmail, fixture.config.Books_UserPassword);
            fixture.Pages.booksPage.AddAuthor("AuthorAddTest");
            actualResult = fixture.Pages.booksPage.AuthorResultModalLabel.Displayed;

            // Assert
            Assert.True(actualResult, "The author is not added.");
        }
    }
}
