using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestAutomationPractice.Pages
{
    class AuthenticationPage
    {
        readonly IWebDriver driver;
        public By authenticationPage = By.Id("authentication");
        public By emailAdressField = By.Id("email");
        public By passwordField = By.Id("passwd");
        public By signInField = By.Id("SubmitLogin");

        public By emailAdressCreate = By.Id("email_create");
        public By CreateAnAccountField = By.Id("SubmitCreate");



        public AuthenticationPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(authenticationPage)); 
        }
    }
}
