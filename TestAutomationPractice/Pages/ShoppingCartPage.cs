using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestAutomationPractice.Pages
{
    public class ShoppingCartPage
    {
        readonly IWebDriver driver;
        public By shoppingCart = By.Id("order");
        public By shoppingCartSummary = By.Id("cart_summary");
        public By summaryProductsQuantity = By.Id("summary_products_quantity");


        public ShoppingCartPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(shoppingCart));
        }
    }
}
