using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using BooksAutomationXUnit.Utilities;
using Xunit;

namespace BooksAutomationXUnit.Tests.SmokeTests
{
    public class LoadLoginPageSTest : BaseTest
    {
        [Fact, Trait("TestCategory", "SmokeTests")]
        public void LoadLoginPage()
        {
            // Arrange
            string expectedPageCaption = "Log iin.";
            string actualPageCaption;

            // Act
            fixture.Pages.loginPage.GetPage();
            actualPageCaption = fixture.Pages.loginPage.CaptionLabel.Text;

            // Assert
            Assert.Equal(expectedPageCaption, actualPageCaption);
        }
    }
}
