using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestAutomationPractice.Pages
{
    public class SearchResultsPage
    {
        readonly IWebDriver driver;
        public By searchPage = By.Id("search");
        public By searchResult = By.ClassName("lighter");

        public SearchResultsPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(searchPage)); 
            
        }
    }
}
