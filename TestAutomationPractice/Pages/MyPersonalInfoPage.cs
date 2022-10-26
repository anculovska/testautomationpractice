using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestAutomationPractice.Pages
{
    public class MyPersonalInfoPage
    {
        readonly IWebDriver driver;
        public By myPersonalInfoPage = By.Id("identity");
        public By lastName = By.Id("lastname");
        public By currentPasswd = By.Id("old_passwd");
        public By saveBtn = By.XPath("//*[contains(text(), 'Save')]");
        public By myName = By.ClassName("account");



        public MyPersonalInfoPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(myPersonalInfoPage));
        }
    }
}
