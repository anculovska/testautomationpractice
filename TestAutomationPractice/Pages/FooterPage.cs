using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestAutomationPractice.Pages
{
    public class FooterPage
    {
        readonly IWebDriver driver;
        public By footer = By.ClassName("footer-container");

        public FooterPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(footer));
        }

        public void ClickOnInformationLink(string title)
        {
            By link = By.CssSelector(".toggle-footer [title = '" + title + "']");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(link)).Click();

        }

        public bool InformationPageIsDisplayed(string pageName)
        {
            By page = By.XPath("//*[@class='navigation_page'][contains(text(),' " + pageName + "')]");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(page)).Displayed;
        }
    }
}
