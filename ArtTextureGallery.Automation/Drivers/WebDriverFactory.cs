using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ArtTextureGallery.Automation.Drivers
{
    public static class WebDriverFactory
    {
        public static IWebDriver Create()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            return new ChromeDriver(options);
        }
    }
}
