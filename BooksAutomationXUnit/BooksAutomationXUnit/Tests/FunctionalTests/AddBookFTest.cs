using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using BooksAutomationXUnit.Utilities;
using Xunit;

namespace BooksAutomationXUnit.Tests.FunctionalTests
{
    public class AddBookFTest : BaseTest
    {
        [Fact, Trait("TestCategory", "FunctionalTests")]
        public void AddBook()
        {
            // Arrange
            bool actualResult;

            // Act
            fixture.Pages.loginPage.GetPage();
            fixture.Pages.loginPage.Login(fixture.config.Books_UserEmail, fixture.config.Books_UserPassword);
            fixture.Pages.booksPage.AddBook("BookAddTest", new int[]{1, 2});
            actualResult = fixture.Pages.booksPage.BookResultModalLabel.Displayed;

            // Assert
            Assert.True(actualResult, "The book is not added.");
        }
    }
}
