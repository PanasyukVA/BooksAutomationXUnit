using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using BooksAutomationXUnit.Utilities;
using Xunit;

namespace BooksAutomationXUnit.Tests.SmokeTests
{
    public class LoadMainPageSTest : BaseTest
    {
        [Fact, Trait("TestCategory", "SmokeTests")]
        public void LoadMainPage()
        {
            // Arrange
            string expectedPageCaption = "Books";
            string actualPageCaption;

            // Act
            fixture.Pages.booksPage.GetPage();
            actualPageCaption = fixture.Pages.booksPage.CaptionLabel.Text;

            // Assert
            Assert.Equal(expectedPageCaption, actualPageCaption);
        }
    }
}
