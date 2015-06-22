using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using BooksAutomationXUnit.Utilities;
using Xunit;

namespace BooksAutomationXUnit.Tests.SmokeTests
{
    public class LogInOnSiteSTest : BaseTest
    {
        [Fact, Trait("TestCategory", "SmokeTests")]
        public void LogInOnSite()
        {
            // Arrange
            bool actualResult;

            // Act
            fixture.Pages.loginPage.GetPage();
            fixture.Pages.loginPage.Login(fixture.config.Books_UserEmail, fixture.config.Books_UserPassword);
            try
            {
                actualResult = fixture.driver.FindElement(By.LinkText(String.Format("Hello {0}!", fixture.config.Books_UserEmail))).Displayed;
            }
            catch (NoSuchElementException)
            {
                actualResult = false;
            }

            // Assert
            Assert.True(actualResult, "Unable to log in on the site");
        }
    }
}
