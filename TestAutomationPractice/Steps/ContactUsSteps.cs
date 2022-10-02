using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TestAutomationPractice.Helpers;
using TestAutomationPractice.Pages;

namespace TestAutomationPractice.Steps
{
    [Binding]
    public class ContactUsSteps : Base
    {

        Utilities ut = new Utilities(Driver);
        HomePage hp = new HomePage(Driver);

        [Given(@"user opens contact us page")]
        public void GivenUserOpensContactUsPage()
        {
            ut.ClickOnElement(hp.contactUs);
        }

        [When(@"user fill in all required fields with '(.*)' heading and '(.*)' message")]
        public void WhenUserFillInAllRequiredFieldsWithHeadingAndMessage(string heading, string message)
        {
            ContactUsPage cup = new ContactUsPage(Driver);
            ut.DropdownSelect(cup.subjectHeading, heading);
            ut.EnterTextInElement(cup.contactEmail, ut.GenerateRandomEmail());
            ut.EnterTextInElement(cup.message, message);


        }

        [When(@"user submits the form")]
        public void WhenUserSubmitsTheForm()
        {
            ContactUsPage cup = new ContactUsPage(Driver);
            ut.ClickOnElement(cup.sendBtn);
        }

        [Then(@"message '(.*)' is presented to the user")]
        public void ThenMessageIsPresentedToTheUser(string successMessage)
        {
            ContactUsPage cup = new ContactUsPage(Driver);
            Assert.That(ut.ReturnTextFromElement(cup.successMessage), Is.EqualTo(successMessage), "Message was not sent to customer service");
        }
    }
}
