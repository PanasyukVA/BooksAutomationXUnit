using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using BooksAutomationXUnit.Utilities;
using Xunit;

namespace BooksAutomationXUnit.Tests.FunctionalTests
{
    public class AddAuthorFTest : BaseTest
    {
        [Fact, Trait("TestCategory", "FunctionalTests")]
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
