using NUnit.Framework;
using OpenQA.Selenium;
using ArtTextureGallery.Automation.Drivers;
using ArtTextureGallery.Automation.Pages;

namespace ArtTextureGallery.Automation.Tests
{
    public class FavoritesTests
    {
        private IWebDriver driver;
        private GalleryPage gallery;
        private FavoritesPage favorites;

        [SetUp]
        public void Setup()
        {
            driver = WebDriverFactory.Create();
            gallery = new GalleryPage(driver);
            favorites = new FavoritesPage(driver);

            gallery.Navigate();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void Add_Artwork_To_Favorites_Should_Increase_Count()
        {
            gallery.FilterByTexture("Textured");
            // пример: първата картина
            driver.FindElement(By.ClassName("add-fav-btn")).Click();

            favorites.Navigate();
            Assert.IsTrue(favorites.FavoritesCount() >= 1);
        }

        [Test]
        public void Remove_Artwork_From_Favorites_Should_Decrease_Count()
        {
            gallery.FilterByTexture("Textured");
            driver.FindElement(By.ClassName("add-fav-btn")).Click();

            favorites.Navigate();
            int before = favorites.FavoritesCount();

            favorites.RemoveArtwork("Textured Artwork 1");
            int after = favorites.FavoritesCount();

            Assert.Less(after, before);
        }
    }
}
