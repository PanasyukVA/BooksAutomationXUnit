using System;
using Xunit;
using BooksAutomationXUnit.Utilities;
using OpenQA.Selenium;

namespace BooksAutomationXUnit.Tests.Smoke
{
    class LogInOnSiteClass : BaseTest
    {
        private TestFixture fixture;

        public LogInOnSiteClass(TestFixture fixture)
            : base(fixture)
        {
            this.fixture = fixture;
        }

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
