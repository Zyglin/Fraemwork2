using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Page
{
    class HomePage
    {
        private const string url = "http://www.turkishairlines.com";

        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Click to find departure point.']")]
        private IWebElement ButtonInputFrom { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Click to find departure point.']/..//input")]
        private IWebElement InputFrom { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Click to find destination.']")]
        private IWebElement ButtonInputTo { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Click to find destination.']/..//input")]
        private IWebElement InputTo { get; set; }
        
        [FindsBy(How = How.XPath, Using = $"//td[@data-month='{0}'][@data-year='{1}']/a[text()='{2}']", dateTime(7).Month, dateTime(7).Year, dateTime(7).Day)]
        private IWebElement DatePlus7Days { get; set; }

        [FindsBy(How = How.XPath, Using = $"//td[@data-month='{0}'][@data-year='{1}']/a[text()='{2}']", dateTime(2).Month, dateTime(2).Year, dateTime(2).Day)]
        private IWebElement DatePlus3Days { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//input[@id='customSpnr1CHILD']/../a[@name='upperCountSpinner']")]
        private IWebElement ChildCountPlusInTicket { get; set; }

        // "//input[@id='customSpnr2INFANT']/../a[@name='upperCountSpinner']"
        [FindsBy(How = How.XPath, Using = "//input[@id='customSpnr2INFANT']/../a[@name='upperCountSpinner']")]
        private IWebElement InfantCountPlusInTicket { get; set; }

        [FindsBy(How = How.Id, Using = "choosePerson_btn1")]
        private IWebElement HrefCloseChoosePerson { get; set; }

        [FindsBy(How = How.Id, Using = "executeSingleCitySubmit")]
        private IWebElement buttonSubmit;

        [FindsBy(How = How.XPath, Using = "//a[@class='hidden-xs btn btn-danger done-btn pull-right toggle-popup ml-20 focusable-calendar-item']")]
        private IWebElement ButtonSubmitDate;


        [FindsBy(How = How.XPath, Using = "//a[@class='fw700 fs-16 bold']")]
        private IWebElement SuggestionsAndDirectionsLink { get; set; }

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(url);
        }

        public void ClickOnTheSuggestionsAndDirectionsLink()
        {
            SuggestionsAndDirectionsLink.Click();          
        }

        private DateTime dateTime(int date)
        {
            return DateTime.Now.AddDays(date);
        }

        public void AirportFlyFrom(string airportFrom)
        {
            ButtonInputFrom.Click();
            InputFrom.SendKeys(airportFrom);//mxp
        }

        public void AirportFlyTo(string airportTo)
        {
            ButtonInputTo.Click();
            InputTo.SendKeys(airportTo);//cdg
        }
        public void SelectDate()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(DatePlus7Days)).Click();
            ButtonSubmitDate.Click();
        }

        public void SelectDateForSecondTest()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(DatePlus3Days)).Click();
            ButtonSubmitDate.Click();
        }
        
        public void ChoosePerson()
        {
            HrefCloseChoosePerson.Click();
        }

        public void SendMainForm()
        {
            buttonSubmit.Click();
        }

        public void ChooseChildAndInfant()
        {
            ChildCountPlusInTicket.Click();
            InfantCountPlusInTicket.Click();
        }
    }
}
