using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace ArtTextureGallery.Automation.Pages
{
    public class FavoritesPage
    {
        private readonly IWebDriver driver;

        public FavoritesPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Navigate()
        {
            driver.Navigate().GoToUrl("https://your-demo-gallery-url.com/favorites");
        }

        private IReadOnlyCollection<IWebElement> FavoriteItems =>
            driver.FindElements(By.ClassName("fav-item"));

        private IWebElement RemoveButton(string artworkName) =>
            driver.FindElement(By.XPath($"//div[contains(text(), '{artworkName}')]/following-sibling::button[text()='Remove']"));

        public int FavoritesCount() => FavoriteItems.Count;

        public bool ContainsArtwork(string artworkName)
        {
            return FavoriteItems.Any(i => i.Text.Contains(artworkName));
        }

        public void RemoveArtwork(string artworkName)
        {
            RemoveButton(artworkName).Click();
        }
    }
}
