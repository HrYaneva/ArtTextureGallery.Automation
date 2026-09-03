using NUnit.Framework;
using OpenQA.Selenium;
using ArtTextureGallery.Automation.Drivers;
using ArtTextureGallery.Automation.Pages;

namespace ArtTextureGallery.Automation.Tests
{
    public class ArtworkDetailsTests
    {
        private IWebDriver driver;
        private ArtworkDetailsPage details;

        [SetUp]
        public void Setup()
        {
            driver = WebDriverFactory.Create();
            details = new ArtworkDetailsPage(driver);
            details.NavigateToArtwork("1"); // примерен ID
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void Artwork_Title_Should_Be_Visible()
        {
            Assert.IsNotEmpty(details.GetTitle());
        }

        [Test]
        public void Artwork_Texture_Should_Be_Visible()
        {
            Assert.IsTrue(details.GetTexture().Contains("Texture"));
        }

        [Test]
        public void Artwork_Price_Should_Be_Valid()
        {
            Assert.IsTrue(details.GetPrice().StartsWith("$"));
        }
    }
}
