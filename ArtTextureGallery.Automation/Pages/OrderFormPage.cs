using OpenQA.Selenium;

namespace ArtTextureGallery.Automation.Pages
{
    public class OrderFormPage
    {
        private readonly IWebDriver driver;

        public OrderFormPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Navigate()
        {
            driver.Navigate().GoToUrl("https://your-demo-gallery-url.com/order");
        }

        private IWebElement NameField => driver.FindElement(By.Id("order-name"));
        private IWebElement EmailField => driver.FindElement(By.Id("order-email"));
        private IWebElement TextureDropdown => driver.FindElement(By.Id("order-texture"));
        private IWebElement MessageField => driver.FindElement(By.Id("order-message"));
        private IWebElement SubmitButton => driver.FindElement(By.Id("order-submit"));
        private IWebElement SuccessMessage => driver.FindElement(By.Id("order-success"));
        private IWebElement ErrorMessage => driver.FindElement(By.Id("order-error"));

        public void FillName(string name) => NameField.SendKeys(name);
        public void FillEmail(string email) => EmailField.SendKeys(email);
        public void SelectTexture(string texture)
        {
            TextureDropdown.Click();
            driver.FindElement(By.XPath($"//option[text()='{texture}']")).Click();
        }
        public void FillMessage(string message) => MessageField.SendKeys(message);

        public void Submit() => SubmitButton.Click();

        public bool IsSuccessVisible() => SuccessMessage.Displayed;
        public bool IsErrorVisible() => ErrorMessage.Displayed;
    }
}
