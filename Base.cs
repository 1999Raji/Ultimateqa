using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.Drivers
{
    public class Base
    {
        public IWebDriver driver;

        public void Launch()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://ultimateqa.com/automation");
            driver.Manage().Window.Maximize();
        }

     
    }
}