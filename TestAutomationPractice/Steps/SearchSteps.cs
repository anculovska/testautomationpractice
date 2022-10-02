using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TestAutomationPractice.Helpers;
using TestAutomationPractice.Pages;

namespace TestAutomationPractice.Steps
{
    [Binding]
    public class SearchSteps : Base
    {
        Utilities ut = new Utilities(Driver);
        HomePage hp = new HomePage(Driver);


        [Given(@"user enters '(.*)' search term")]
        public void GivenUserEntersSearchTerm(string term)
        {
            ut.EnterTextInElement(hp.searchField, term);
        }
        
        [When(@"user submits the search")]
        public void WhenUserSubmitsTheSearch()
        {
            ut.ClickOnElement(hp.searchBtn);
        }
        
        [Then(@"results for '(.*)' search term are displayed")]
        public void ThenResultsForSearchTermAreDisplayed(string term)
        {
           SearchResultsPage srp = new SearchResultsPage(Driver);
            Assert.That(ut.ReturnTextFromElement(srp.searchResult), Does.Contain(term), "Wrong search results are displayes");
        }
    }
}
