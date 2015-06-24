using System;
using BooksAutomationXUnit.Utilities;
using Xunit;

namespace BooksAutomationXUnit.Tests.Functional
{
    class EditAuthorClass : BaseTest
    {
        private TestFixture fixture;

        public EditAuthorClass(TestFixture fixture)
            : base(fixture)
        {
            this.fixture = fixture;
        }

        public void EditAuthor()
        {
            // Arrange
            bool actualResult;

            // Act
            fixture.Pages.loginPage.GetPage();
            fixture.Pages.loginPage.Login(fixture.config.Books_UserEmail, fixture.config.Books_UserPassword);
            fixture.Pages.booksPage.EditAuthor(1, "AuthorEditTest");
            actualResult = fixture.Pages.booksPage.AuthorResultModalLabel.Displayed;

            // Assert
            Assert.True(actualResult, "The author is not edited.");
        }
    }
}
