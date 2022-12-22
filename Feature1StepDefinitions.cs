using System;
using TechTalk.SpecFlow;
using SpecFlowProject.Drivers;
using OpenQA.Selenium;
using SpecFlowProject.Pages;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class Feature1StepDefinitions : Base
    {
        //Base basedriver;

        public IWebDriver driver;

        [Given(@"Navigate to Home Page")]
        public void GivenNavigateToHomePage()
        {
            Launch();
            //throw new PendingStepException();
            //basedriver = new Base();
           
        }

        
        
          //Signup signup;

        
      
        [When(@"I click on Login Automation")]
        public void WhenIClickOnLoginAutomation()
        {

            //throw new PendingStepException();
            Signup signup =  new Signup(driver);
            //signup.login.Click();
            
        }

        [When(@"I Click on create a new account")]
        public void WhenIClickOnCreateANewAccount()
        {
            // throw new PendingStepException();
            Signup signup = new Signup(driver);
           // signup.account.Click();
        }

        [Then(@"I should see the Registration Page")]
        public void ThenIShouldSeeTheRegistrationPage()
        {
            //throw new PendingStepException();

        }

        [Given(@"Navigating to Home Page")]
        public void GivenNavigatingToHomePage()
        {
            throw new PendingStepException();
        }

        [When(@"I click on Courses")]
        public void WhenIClickOnCourses()
        {
            throw new PendingStepException();
        }

        [Then(@"I should see the Courses Page")]
        public void ThenIShouldSeeTheCoursesPage()
        {
            throw new PendingStepException();
        }

    }
}
