using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace TestAutomationPractice.Helpers
{
    [Binding]

    public class Base
    {
        public static IWebDriver Driver { get; set; }


        [BeforeScenario]

        public static void BeforeScenario()
        {
            Driver = new ChromeDriver(); // chrome driver klasa implementira iwebdriver interface
            Driver.Manage().Window.Maximize();

            // Isto kao gore, samo razbijeno na korake, gore su pozivi kaskadirani
            //IOptions options = Driver.Manage();
            //IWindow window = options.Window;
            //window.Maximize();

            string url = "http://automationpractice.com/";
            Driver.Url = url;
        }


        [AfterScenario]

        public static void AfterScenarion()
        {
            Driver.Quit();
        }
     
    }
}
