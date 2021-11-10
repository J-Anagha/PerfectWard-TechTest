using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PerfectWard_TestProject;


namespace PerfectWard_TechTest.PageObjects
{
    public class BasePage
    {
        private DriverManager driver;

        public BasePage(DriverManager d)
        {
            driver = d;
        }

        public void Click(By elementToClickLocator)
        {
            driver.Driver.FindElement(elementToClickLocator).Click();
        }

        public void JavascriptClick(By elementToClickLocator)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver.Driver;
            executor.ExecuteScript("arguments[0].click();", driver.Driver.FindElement(elementToClickLocator));
        }

        public bool IsElementAccessible(By elementLocator)
        {
            IWebElement element = driver.Driver.FindElement(elementLocator);
            return (element.Displayed && element.Enabled);
        }

        public void Clear(By elementLocator)
        {
            driver.Driver.FindElement(elementLocator).Clear();
        }
        public string GetText(By elementLocator)
        {
            return driver.Driver.FindElement(elementLocator).Text;
        }

        public void SetText(By elementLocator, string value)
        {
            IWebElement fieldToSet = driver.Driver.FindElement(elementLocator);
            fieldToSet.SendKeys(value);
        }
        
        public void SelectDropdownValue(By dropdownLocator, string value)
        {
            SelectElement dropdown = new SelectElement(driver.Driver.FindElement(dropdownLocator));
            dropdown.SelectByValue(value);
        }



    }


}
