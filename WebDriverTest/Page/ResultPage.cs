using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Page
{
    class ResultPage
    {       
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//div[@class='bold text-muted']")]
        private IWebElement ResultFlightDuration { get; set; }

        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public string FlightDuration()
        {
            return ResultFlightDuration.Text;
        }
       

       
    }
}
