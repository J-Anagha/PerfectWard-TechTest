using OpenQA.Selenium;
using PerfectWard_TestProject;
using System;

namespace PerfectWard_TechTest.PageObjects
{
    public class HomePage : BasePage
    {
        private DriverManager driver;

        //PageElements locators

        By topMenu = By.CssSelector("#navbar > div");
        By homePageNav = By.CssSelector("#Layer_2");
        By covid19Nav = By.LinkText("IPC");
        By featuresNav = By.LinkText("Features");
        By ourSolutionNav = By.LinkText("Our Solution");
        By resourcesNav = By.LinkText("Resources");
        By contactUsNav = By.LinkText("Contact");
        By bookDemoButton = By.LinkText("Book a Demo");

        public HomePage(DriverManager d)
        : base(d)
        {
            driver = d;
        }

        public bool IsTopNavAccessible(string navItem)
        {
            if (driver.Driver.FindElement(topMenu).Displayed)
            {
                switch (navItem)
                {
                    case "Home":
                        return IsElementAccessible(homePageNav);
                    case "Covid19(IPC)":
                        return IsElementAccessible(covid19Nav);
                    case "Features":
                        return IsElementAccessible(featuresNav);
                    case "Our Solutions":
                        return IsElementAccessible(ourSolutionNav);
                    case "Resources":
                        return IsElementAccessible(resourcesNav);
                    case "Contact":
                        return IsElementAccessible(contactUsNav);
                    case "default":
                        Console.WriteLine($"Top navigation menu {navItem} not found");
                        break;
                }
            }
            return false;
        }

        public bool IsBookADemoButtonAvailable(string navItem)
        {
            switch (navItem)
            {
                case "Home":
                    Click(homePageNav);
                    return IsElementAccessible(bookDemoButton);

                case "Covid19(IPC)":
                    Click(covid19Nav);
                    return IsElementAccessible(bookDemoButton);

                case "Features":
                    Click(featuresNav);
                    return IsElementAccessible(bookDemoButton);

                case "Our Solutions":
                    Click(ourSolutionNav);
                    return IsElementAccessible(bookDemoButton);

                case "Resources":
                    Click(resourcesNav);
                    return IsElementAccessible(bookDemoButton);

                case "Contact":
                    Click(contactUsNav);
                    return IsElementAccessible(bookDemoButton);

                case "default":
                    break;
            }

            return false;
        }

        public void ClickContactUsPageLink()
        {
            JavascriptClick(contactUsNav);
        }
    }
}
