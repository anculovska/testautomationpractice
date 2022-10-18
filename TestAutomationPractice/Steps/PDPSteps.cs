using System;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestAutomationPractice.Helpers;
using TestAutomationPractice.Pages;

namespace TestAutomationPractice.Steps
{
    [Binding]
    public class PDPSteps : Base
    {
        Utilities ut = new Utilities(Driver);

        private readonly ProductData productData;
        public PDPSteps(ProductData productData)
        {
            this.productData = productData;
        }


        [Given(@"user opens '(.*)' section")]
        public void GivenUserOpensSection(string cat)
        {
            ut.ReturnCategoryList(cat)[1].Click();
        }
        
        [Given(@"opens first product from the list")]
        public void GivenOpensFirstProductFromTheList()
        {
            PLPage plp = new PLPage(Driver);
            ut.ClickOnElement(plp.firstProduct);
        }
        
        [Given(@"increases quantity to (.*)")]
        public void GivenIncreasesQuantityTo(string qty)
        {
            By iframe = By.ClassName("fancybox-iframe");
            Driver.SwitchTo().Frame(Driver.FindElement(iframe)); // prebacili smo se na drugi prozor
            PDPage pdp = new PDPage(Driver);
            Driver.FindElement(pdp.quantity).Clear(); //obrisali smo broj iz polja qty
            ut.EnterTextInElement(pdp.quantity, qty); //upisali sni broj 2 u qty
            productData.ProductName = ut.ReturnTextFromElement(pdp.productName); //sacuvali smo proizvod

        }
        
        [When(@"user clicks on add to cart button")]
        public void WhenUserClicksOnAddToCartButton()
        {
            PDPage pdp = new PDPage(Driver);
            ut.ClickOnElement(pdp.addToCartBtn);
        }
        
        [When(@"user proceeds to checkout")]
        public void WhenUserProceedsToCheckout()
        {
            PDPage pdp = new PDPage(Driver);
            ut.ClickOnElement(pdp.proceedToCheckoutBtn);
        }
        
        [Then(@"cart summary is displayed and product is added to cart")]
        public void ThenCartSummaryIsDisplayedAndProductIsAddedToCart()
        {
            ShoppingCartPage scp = new ShoppingCartPage(Driver);

            Assert.True(ut.ElementIsDisplayed(scp.shoppingCartSummary));
            Assert.True(ut.ElementIsDisplayed(scp.summaryProductsQuantity));
        }
    }
}
