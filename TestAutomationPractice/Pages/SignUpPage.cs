using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestAutomationPractice.Pages
{
    public class SignUpPage
    {
        readonly IWebDriver driver;
        public By personalInformation = By.Id("account-creation_form");
        public By firstName = By.Id("customer_firstname");
        public By lastName = By.Id("customer_lastname");
        public By customerEmail = By.Id("email");
        public By customerPasswd = By.Id("passwd");
        public By customerAddress = By.Id("address1");
        public By city = By.Id("city");
        public By state = By.Id("id_state");
        public By postalCode = By.Id("postcode");
        public By phone = By.Id("phone_mobile");
        public By registerBtn = By.Id("submitAccount");



        public SignUpPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(personalInformation));

        }
    }
}
