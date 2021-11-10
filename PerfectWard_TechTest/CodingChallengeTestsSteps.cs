using NUnit.Framework;
using OpenQA.Selenium;
using PerfectWard_TechTest.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace PerfectWard_TestProject
{
    [Binding]
    public class CodingChallengeTestsSteps
    {
        private DriverManager driver;
        private HomePage homepage;
        private ContactUsPage contactPage;
        private const string siteUrl = "https://www.perfectward.com/";

        public CodingChallengeTestsSteps(
            DriverManager d, 
            HomePage hp, 
            ContactUsPage cp)
        {
            driver = d;
            homepage = hp;
            contactPage = cp;
        }

        [Given(@"I navigate to the Home page")]
        [When(@"I navigate to the Home page")]
        public void GivenINavigateToTheHomePage()
        {
            driver.Driver.Navigate().GoToUrl(siteUrl);
        }

        [Then(@"I should be able to access following top navigation menu items")]
        public void ThenIShouldBeAbleToAccessFollowingTopNavigationMenuItems(Table table)
        {
            var rows = table.Rows;
                        
            foreach (var row in rows)
            {
                string navItem = row[0];
                Assert.IsTrue(homepage.IsTopNavAccessible(navItem));
            }
        }

        [Then(@"the Book a demo button should be available for following top navigation menu items")]
        public void ThenTheBookADemoButtonShouldBeAvailableForFollowingTopNavigationMenuItems(Table table)
        {
            var rows = table.Rows;
            foreach (var row in rows)
            {
                string navItem = row[0];
                Assert.IsTrue(homepage.IsBookADemoButtonAvailable(navItem));
            }
        }

        [Given(@"I open the Contact Us page")]
        public void GivenIOpenTheContactUspage()
        {
            homepage.ClickContactUsPageLink();
        }

        [Given(@"I complete the contact form except the ""(.*)"" field")]
        public void GivenICompleteTheContactFormExceptTheField(string fieldName)
        {
            contactPage.FillContactForm();
            contactPage.ClearField(fieldName);
        }

        [When(@"I submit the form")]
        public void WhenISubmitTheForm()
        {
            contactPage.SubmitForm();
        }

        [Then(@"I should receive an error message ""(.*)"" for the Message field")]
        public void ThenIShouldReceiveAnErrorMessage(string errorMessage)
        {
            String actualMessage = contactPage.GetErrorTextForMessageField();
            Assert.AreEqual(errorMessage, actualMessage);
        }

        [Then(@"I should receive the error message ""(.*)"" above the form")]
        public void ThenIShouldReceiveTheErrorMessageJustAboveTheForm(string errorMessageAtTop)
        {
            string errorAtTop = contactPage.GetErrorTextAtTopOfTheForm();
            Assert.AreEqual(errorMessageAtTop, errorAtTop);
        }
    }
}
