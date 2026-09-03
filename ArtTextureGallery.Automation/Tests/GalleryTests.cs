using NUnit.Framework;
using OpenQA.Selenium;
using ArtTextureGallery.Automation.Drivers;
using ArtTextureGallery.Automation.Pages;

namespace ArtTextureGallery.Automation.Tests
{
    public class GalleryTests
    {
        private IWebDriver driver;
        private GalleryPage gallery;

        [SetUp]
        public void Setup()
        {
            driver = WebDriverFactory.Create();
            gallery = new GalleryPage(driver);
            gallery.Navigate();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void Gallery_Should_Load_Artworks()
        {
            Assert.IsTrue(gallery.ArtworkCount() >= 6);
        }

        [Test]
        public void Filter_Textured_Should_Show_Only_Textured()
        {
            gallery.FilterByTexture("Textured");
            Assert.IsTrue(gallery.AllArtworksAreTextured());
        }
    }
}
