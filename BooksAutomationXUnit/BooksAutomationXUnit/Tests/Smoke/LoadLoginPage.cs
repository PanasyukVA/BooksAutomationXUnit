using System;
using Xunit;
using BooksAutomationXUnit.Utilities;

namespace BooksAutomationXUnit.Tests.Smoke
{
    class LoadLoginPageClass : BaseTest
    {
        private TestFixture fixture;

        public LoadLoginPageClass(TestFixture fixture) 
            : base(fixture)
        {
            this.fixture = fixture;
        }

        public void LoadLoginPage()
        {
            // Arrange
            string expectedPageCaption = "Log in.";
            string actualPageCaption;

            // Act
            fixture.Pages.loginPage.GetPage();
            actualPageCaption = fixture.Pages.loginPage.CaptionLabel.Text;

            // Assert
            Assert.Equal(expectedPageCaption, actualPageCaption);
        }
    }
}
