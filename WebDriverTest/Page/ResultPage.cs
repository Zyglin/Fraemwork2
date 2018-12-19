using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Page
{
    class ResultPage
    {       
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//div[@class='bold text-muted']")]
        private IWebElement ResultFlightDuration { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@class='display-block mb-0 fw500']")]
        private IWebElement ResultFlightMember { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-bind='i18n-text: { key: 'Error-0B-015' }']")]
        private IWebElement FlighNotFound { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-bind='i18n-text: { key: 'Error-0B-015' }']")]
        private IWebElement DepartureFlight { get; set; }


        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public string FlightDuration()
        {
            return ResultFlightDuration.Text;
        }   
        
        public string FlightMemberResultDuration()
        {
            return ResultFlightMember.Text;
        }

        public string FlighNotFoundError()
        {
            return FlighNotFound.Text;
        }

        public string DepartureFlightText()
        {
            return DepartureFlight.Text;
        }
    }
}
