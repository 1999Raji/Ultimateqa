using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SpecFlowProject.Drivers;

namespace SpecFlowProject.Pages
{
    // private readonly IWebDriver webDriver;

    public class Signup : Base
    {
       IWebDriver driver;

       //public Signup(IWebDriver driver) => this.driver = driver;

        public Signup(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
      
         [FindsBy(How = How.XPath, Using = "//*[@id=\"post-507\"]/div/div[1]/div/div[2]/div/div[1]/div/div/div/div/ul/li[6]/a")]

         public IWebElement login { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-507\"]/div/div[1]/div/div[2]/div/div[1]/div/div/div/div/ul/li[6]/a")]

        public IWebElement account { get; set; }











    }
}
