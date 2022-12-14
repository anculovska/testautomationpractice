using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TestAutomationPractice.Helpers;
using TestAutomationPractice.Pages;

namespace AutomationPracticeFramework.Steps
{
    [Binding]
    public class MyAccountSteps : Base
    {
        Utilities ut = new Utilities(Driver);
        HomePage hp = new HomePage(Driver);

        private readonly PersonData personData; //tipa je persondata

        public MyAccountSteps(PersonData personData)
        {
            this.personData = personData;
        }


        [Given(@"user opens sign in page")]
        public void GivenUserOpensSignInPage()
        {
            ut.ClickOnElement(hp.signIn);
        }
        
        [Given(@"enters correct credentials")]
        public void GivenEntersCorrectCredentials()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.EnterTextInElement(ap.emailAdressField, TestConstants.CustomerEmail);
            ut.EnterTextInElement(ap.passwordField, TestConstants.CustomerPasswd);
        }
        
        [StepDefinition(@"user submits the login form")]
        public void WhenUserSubmitsTheLoginForm()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.ClickOnElement(ap.signInField);
        }
        
        [Then(@"user will be logged in")]
        public void ThenUserWillBeLoggedIn()
        {
            MyAccountPage mp = new MyAccountPage(Driver);
            Assert.True(ut.ElementIsDisplayed(mp.signOutBtn), "User is not logged in");
            
        }


        [Given(@"initiates a flow for creating an account")]
        public void GivenInitiatesAFlowForCreatingAnAccount()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.EnterTextInElement(ap.emailAdressCreate, ut.GenerateRandomEmail());
            ut.ClickOnElement(ap.CreateAnAccountField);
        }

        [Given(@"user enters all required personal details")]
        public void GivenUserEntersAllRequiredPersonalDetails()
        {
            SignUpPage sup = new SignUpPage(Driver);
            ut.EnterTextInElement(sup.firstName, TestConstants.FirstName);
            ut.EnterTextInElement(sup.lastName, TestConstants.LastName);
            personData.FullName = TestConstants.FirstName + " " + TestConstants.LastName;
            //ut.EnterTextInElement(sup.customerEmail, TestConstants.CustomerEmail);
            ut.EnterTextInElement(sup.customerPasswd, TestConstants.CustomerPasswd);
            ut.EnterTextInElement(sup.customerAddress, TestConstants.CustomerAdress);
            ut.EnterTextInElement(sup.city, TestConstants.City);
            ut.DropdownSelect(sup.state, TestConstants.State);
            ut.EnterTextInElement(sup.postalCode, TestConstants.PostalCode);
            ut.EnterTextInElement(sup.phone, TestConstants.Phone);
        }

        [When(@"user submits the sign up form")]
        public void WhenUserSubmitsTheSignUpForm()
        {
            SignUpPage sup = new SignUpPage(Driver);
            ut.ClickOnElement(sup.registerBtn);
        }

        [Then(@"user's full name is displayed")]
        public void ThenUserSFullNameIsDisplayed()
        {
            Assert.True(ut.TextPresentInElement(personData.FullName), "User's full name is not displayed in the header");
        }





        [Given(@"user opens MY PERSONAL INFORMATION")]
        public void GivenUserOpensPersonalInformation()
        {
            MyAccountPage mp = new MyAccountPage(Driver);
            ut.ClickOnElement(mp.myPersonalInfoBtn);
        }


        [When(@"user enters new last name")]
        public void WhenUserEntersNewLastname()
        {
            MyPersonalInfoPage mpi = new MyPersonalInfoPage(Driver);
            Driver.FindElement(mpi.lastName).Clear(); //obrisali smo postojece prezime
            personData.LastName = ut.RandomString(7);
            ut.EnterTextInElement(mpi.lastName, personData.LastName);

        }

        [When(@"enters current password")]
        public void WhenUserEntersCurrentPassw()
        {
            MyPersonalInfoPage mpi = new MyPersonalInfoPage(Driver);
            ut.EnterTextInElement(mpi.currentPasswd, TestConstants.CustomerPasswd);
        }

        [When(@"save the changes")]
        public void WhenUserSaveChanges()
        {
            MyPersonalInfoPage mpi = new MyPersonalInfoPage(Driver);
            ut.ClickOnElement(mpi.saveBtn);
        }

        [Then(@"last name is updated")]
        public void ThenUsersLastNameIsUpdated()
        {
            MyPersonalInfoPage mpi = new MyPersonalInfoPage(Driver);
            Assert.That(ut.ReturnTextFromElement(mpi.myName), Does.Contain(personData.LastName), "Last name is not updated"); 
            
        }


    }
}
