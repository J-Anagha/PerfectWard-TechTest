using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace PerfectWard_TestProject
{
    public class DriverManager
    {
        private IWebDriver driver = null;
        public IWebDriver Driver { get { return driver; } }

        public DriverManager()
        {
            driver = new ChromeDriver(@"../../../Drivers");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driver.Manage().Window.Maximize();
        }
    }
}
