using TechTalk.SpecFlow;

namespace PerfectWard_TestProject
{
    [Binding]
    public class Hooks
    {
        private DriverManager driver;

        public Hooks(DriverManager d)
        {
            driver = d;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Driver.Quit();
        }
        
    }
}
