using OpenQA.Selenium;

namespace ArtTextureGallery.Automation.Pages
{
    public class ArtworkDetailsPage
    {
        private readonly IWebDriver driver;

        public ArtworkDetailsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void NavigateToArtwork(string artworkId)
        {
            driver.Navigate().GoToUrl($"https://your-demo-gallery-url.com/artwork/{artworkId}");
        }

        private IWebElement Title => driver.FindElement(By.Id("art-title"));
        private IWebElement Texture => driver.FindElement(By.Id("art-texture"));
        private IWebElement Size => driver.FindElement(By.Id("art-size"));
        private IWebElement Price => driver.FindElement(By.Id("art-price"));
        private IWebElement AddToFavoritesButton => driver.FindElement(By.Id("add-fav-btn"));

        public string GetTitle() => Title.Text;
        public string GetTexture() => Texture.Text;
        public string GetSize() => Size.Text;
        public string GetPrice() => Price.Text;

        public void AddToFavorites()
        {
            AddToFavoritesButton.Click();
        }
    }
}
