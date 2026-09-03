using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace ArtTextureGallery.Automation.Pages
{
    public class GalleryPage
    {
        private readonly IWebDriver driver;

        public GalleryPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Navigate()
        {
            driver.Navigate().GoToUrl("https://your-demo-gallery-url.com/gallery");
        }

        private IReadOnlyCollection<IWebElement> Artworks =>
            driver.FindElements(By.ClassName("art-item"));

        private IWebElement TextureFilter(string textureType) =>
            driver.FindElement(By.XPath($"//button[text()='{textureType}']"));

        public int ArtworkCount() => Artworks.Count;

        public void FilterByTexture(string textureType)
        {
            TextureFilter(textureType).Click();
        }

        public bool AllArtworksAreTextured()
        {
            return Artworks.All(a => a.Text.Contains("Texture:"));
        }
    }
}
