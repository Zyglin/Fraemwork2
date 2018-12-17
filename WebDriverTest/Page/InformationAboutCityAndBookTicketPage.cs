using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Page
{
    class InformationAboutCityAndBookTicketPage
    {

        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//h1[@class='fs-60 pt-0 mt-0 mb-30 1h-55']//")]
        private IWebElement informationAboutCityWhereBookTicket { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='destination-btn-fix']//")]
        private IWebElement buttonBookTicket { get; set; }

        public InformationAboutCityAndBookTicketPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public string InformationInWhichCityWeBookTicketsText()
        {
          
            return informationAboutCityWhereBookTicket.Text;
        }
        
        public string GettingTheTextOftheButtonToBookaFlight()
        {
            return buttonBookTicket.Text;
        }
    }
}
