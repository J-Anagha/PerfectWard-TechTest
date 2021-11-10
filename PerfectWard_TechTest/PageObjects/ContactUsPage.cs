using OpenQA.Selenium;
using PerfectWard_TestProject;


namespace PerfectWard_TechTest.PageObjects
{
    public class ContactUsPage : BasePage
    {
        private DriverManager driver;

        //PageElement Locators

        By contactForm = By.Id("General Enquiry");
        By firstName = By.Id("form-input-firstName");
        By lastName = By.Id("form-input-lastName");
        By email = By.Id("form-input-email");
        By phoneNum = By.Id("form-input-telephone");
        By role = By.Id("form-input-roles");
        By sector = By.Id("form-input-sectors");
        By organisation = By.Id("form-input-companyName");
        By hearAbtUs = By.Id("form-input-referralChannel");
        By message = By.Id("form-input-message");
        By agreeToTermsChkBox = By.Id("form-input-gdpr");
        By submitButton = By.XPath("/html/body/div[2]/div[2]/div/div/div/div/div[1]/div/div[2]/div[2]/form/div[9]/div/button");
        By errorAtTop = By.XPath("//*[@id='General Enquiry']/div[1]/p");
        By errorForMessageField = By.XPath("//*[@id='General Enquiry']/div[8]/div/ul/li");
        public ContactUsPage(DriverManager d)
            :base(d)
        {
            driver = d;
        }

        public void FillContactForm()
        {
            if (driver.Driver.FindElement(contactForm).Displayed)
            {
                SetText(firstName, "FName");
                SetText(lastName, "LName");
                SetText(email, "test@mailinator.com");
                SetText(phoneNum, "01234456789");
                SelectDropdownValue(role, "CFO");
                SelectDropdownValue(sector, "NHS other");
                SetText(organisation, "Test");
                SelectDropdownValue(hearAbtUs, "Referral");
                SetText(message, "Test");
                JavascriptClick(agreeToTermsChkBox);
            }
        }

        public void ClearField(string fieldName)
        {
            switch (fieldName)
            {
                case "Message":
                    Clear(message);
                    break;
                case "default":
                    break;
            }
        }

        public void SubmitForm()
        {
            JavascriptClick(submitButton);
        }

        public string GetErrorTextForMessageField()
        {
            return GetText(errorForMessageField);
        }

        public string GetErrorTextAtTopOfTheForm()
        {
            return GetText(errorAtTop);
        }
    }
}
