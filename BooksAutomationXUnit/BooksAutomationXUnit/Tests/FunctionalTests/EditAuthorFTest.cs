using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using BooksAutomationXUnit.Utilities;
using Xunit;

namespace BooksAutomationXUnit.Tests.FunctionalTests
{
    public class EditAuthorFTest : BaseTest
    {
        [Fact, Trait("TestCategory", "FunctionalTests")]
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
