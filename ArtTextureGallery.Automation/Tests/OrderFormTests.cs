using NUnit.Framework;
using OpenQA.Selenium;
using ArtTextureGallery.Automation.Drivers;
using ArtTextureGallery.Automation.Pages;

namespace ArtTextureGallery.Automation.Tests
{
    public class OrderFormTests
    {
        private IWebDriver driver;
        private OrderFormPage form;

        [SetUp]
        public void Setup()
        {
            driver = WebDriverFactory.Create();
            form = new OrderFormPage(driver);
            form.Navigate();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void Submit_Valid_Form_Should_Show_Success()
        {
            form.FillName("Hristinka Yaneva");
            form.FillEmail("hristinka@example.com");
            form.SelectTexture("Textured");
            form.FillMessage("I want a custom textured painting.");
            form.Submit();

            Assert.IsTrue(form.IsSuccessVisible());
        }

        [Test]
        public void Submit_Empty_Form_Should_Show_Error()
        {
            form.Submit();
            Assert.IsTrue(form.IsErrorVisible());
        }

        [Test]
        public void Submit_Invalid_Email_Should_Show_Error()
        {
            form.FillName("Hristinka");
            form.FillEmail("invalid-email");
            form.SelectTexture("Mixed");
            form.FillMessage("Test message");
            form.Submit();

            Assert.IsTrue(form.IsErrorVisible());
        }
    }
}
