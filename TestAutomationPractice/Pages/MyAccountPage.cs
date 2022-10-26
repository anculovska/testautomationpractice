using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestAutomationPractice.Pages
{
    public class MyAccountPage
    {
        readonly IWebDriver driver;
        public By myAccountPage = By.Id("my-account");
        public By signOutBtn = By.ClassName("logout");
        public By myPersonalInfoBtn = By.XPath("//*[contains(text(), 'My personal information')]");
        


        public MyAccountPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(myAccountPage));
        }
    }
}
