using System;
using Xunit;
using BooksAutomationXUnit.Utilities;

namespace BooksAutomationXUnit.Tests.Smoke
{
    class LoadMainPageClass : BaseTest
    {
        private TestFixture fixture;

        public LoadMainPageClass(TestFixture fixture)
            : base(fixture)
        {
            this.fixture = fixture;
        }

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
