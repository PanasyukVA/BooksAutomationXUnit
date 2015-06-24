using System;
using BooksAutomationXUnit.Utilities;
using Xunit;

namespace BooksAutomationXUnit.Tests.Functional
{
    class AddBookClass : BaseTest
    {
        private TestFixture fixture;

        public AddBookClass(TestFixture fixture)
            : base(fixture)
        {
            this.fixture = fixture;
        }

        public void AddBook()
        {
            // Arrange
            bool actualResult;

            // Act
            fixture.Pages.loginPage.GetPage();
            fixture.Pages.loginPage.Login(fixture.config.Books_UserEmail, fixture.config.Books_UserPassword);
            fixture.Pages.booksPage.AddBook("BookAddTest", new int[] { 1, 2 });
            actualResult = fixture.Pages.booksPage.BookResultModalLabel.Displayed;

            // Assert
            Assert.True(actualResult, "The book is not added.");
        }
    }
}
