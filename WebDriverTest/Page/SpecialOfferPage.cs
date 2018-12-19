using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Page
{
    class SpecialOfferPage
    {

        private const string url = "http://www.turkishairlines.com";

        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//span[@portselect-id='portTXTMSQ']")]
        private IWebElement FieldDirection { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-danger bold']//")]
        private IWebElement buttonBookIstambul { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Click to find destination.']")]
        private IWebElement ButtonInputTo { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Click to find destination.']/..//input")]
        private IWebElement InputTo { get; set; }

        [FindsBy(How = How.XPath, Using = "a[@data-bind='click: searchFlight']")]
        private IWebElement SearchFlightButton { get; set; }

        [FindsBy(How = How.XPath, Using = "a[@class='btn btn-transparent bold']")]
        private IWebElement ToBookLink { get; set; }

        public SpecialOfferPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public string AutoFieldDirectionResult()
        {
            return FieldDirection.Text;          
        }
        
        public void ClickOnIstanbulToBook()
        {
            buttonBookIstambul.Click();
        }

        public string FindSpechialOfferForFlight(string airportTo)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(ButtonInputTo)).Click();
            InputTo.SendKeys(airportTo);
            SearchFlightButton.Click();
            return ToBookLink.Text;
        }
    }
}
