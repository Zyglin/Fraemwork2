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

        [FindsBy(How = How.XPath, Using = $"//td[@data-month='{0}'][@data-year='{1}']/a[text()='{2}']", dateTime(0).Month, dateTime(0).Year, dateTime(0).Day)]
        private IWebElement Date { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='customSpnr0ADULT']/../a[@name='upperCountSpinner']")]
        private IWebElement AdultsCountPlusInTicket { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='customSpnr1CHILD']/../a[@name='upperCountSpinner']")]
        private IWebElement ChildCountPlusInTicket { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='customSpnr2INFANT']/../a[@name='upperCountSpinner']")]
        private IWebElement InfantCountPlusInTicket { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@class='ws-normal vertical-top dib']")]
        private IWebElement MaxCountPeopleError { get; set; }

        [FindsBy(How = How.Id, Using = "choosePerson_btn1")]
        private IWebElement HrefCloseChoosePerson { get; set; }

        [FindsBy(How = How.Id, Using = "executeSingleCitySubmit")]
        private IWebElement buttonSubmit { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@class='word-wrap']")]
        private IWebElement DateError { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@class='ws-normal vertical-top dib']")]
        private IWebElement ChildCountError { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='hidden-xs btn btn-danger done-btn pull-right toggle-popup ml-20 focusable-calendar-item']")]
        private IWebElement ButtonSubmitDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='fw700 fs-16 bold']")]
        private IWebElement SuggestionsAndDirectionsLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='#bookerDeparTab']")]
        private IWebElement FlightStatusButton { get; set; }

        [FindsBy(How = How.Id, Using = "membershipNumber")]
        private IWebElement MembershipNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@data-bind='click : findFlights']")]
        private IWebElement FindFlight { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='fw700 fs-16 bold']")]
        private IWebElement ShowAllCopmaniesLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='white mini-booker-link mb-5']")]
        private IWebElement multiCityLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Click to find departure point.']")]
        private List<IWebElement> ButtonInputFromCollection { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Click to find departure point.']/..//input")]
        private List<IWebElement> InputFromCollection { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Click to find destination.']")]
        private List<IWebElement> ButtonInputToColection { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Click to find destination.']/..//input")]
        private List<IWebElement> InputToCollection { get; set; }

        [FindsBy(How = How.XPath, Using = $"//td[@data-month='{0}'][@data-year='{1}']/a[text()='{2}']", dateTime(0).Month, dateTime(0).Year, dateTime(0).Day)]
        private List<IWebElement> MultiDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@data-bind='click: $root.executeMultiCityFlightSearch']")]
        private IWebElement MultiCitySearch { get; set; }

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
            wait.Until(ExpectedConditions.ElementIsVisible(ButtonInputFrom)).Click();
            InputFrom.SendKeys(airportFrom);
        }

        public void AirportFlyTo(string airportTo)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(ButtonInputTo)).Click();
            InputTo.SendKeys(airportTo);
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

        public void SelectDateForThirdTest()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(Date)).Click();
            ButtonSubmitDate.Click();
        }
        public void ChoosePersonButtonOK()
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

        public void Choose7AdultAnd7Child()
        {
            for (int i = 0; i < 6; i++)
            {
                AdultsCountPlusInTicket.Click();
            }
            for (int i = 0; i < 7; i++)
            {
                ChildCountPlusInTicket.Click();
            }
        }

        public string MaxCountPeopleErrorInFrom()
        {
            return MaxCountPeopleError.Text;
        }

        public string DateErorInForm()
        {
            return DateError.Text;
        } 

        public void Choose3AdultsAnd5Child()
        {
            for (int i = 0; i < 2; i++)
            {
                AdultsCountPlusInTicket.Click();
            }
            for (int i = 0; i < 5; i++)
            {
                ChildCountPlusInTicket.Click();
            }
        }

        public string ChildCountErrorInForm()
        {
            return ChildCountError.Text;
        }

        public void FlightStatus()
        {
            FlightStatusButton.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(MembershipNumber)).SendKeys("284");
            FindFlight.Click();
        }

        public void CLickShowAllCompanies()
        {
            ShowAllCopmaniesLink.Click();
        }

        public void SendMultiChoose()
        {
            multiCityLink.Click();
            var buttonInputToCollections = new IWebElement[2];
            var inputToCollections = new IWebElement[2];
            var buttonInputFromCollections = new IWebElement[2];
            var inputFromCollections = new IWebElement[2];
            var tableDate = new IWebElement[2];
            string[] airports = new string[] { "msq", "vko", "ecn" };
            int i = 0;
            foreach (var p in ButtonInputFromCollection)
            {
                buttonInputToCollections[i] = p;
                i++;
            }
            i = 0;
            foreach (var p in InputFromCollection)
            {
                buttonInputToCollections[i] = p;
                i++;
            }
            i = 0;
            foreach (var p in ButtonInputToColection)
            {
                buttonInputToCollections[i] = p;
                i++;
            }
            i = 0;
            foreach (var p in InputToCollection)
            {
                buttonInputToCollections[i] = p;
                i++;
            }

            i = 0;
            foreach (var p in MultiDate)
            {
                buttonInputToCollections[i] = p;
                i++;
            }
            for (int i = 0; i < 2; i++)
            {
                buttonInputFromCollections[i].Click();
                inputFromCollections[i].SendKeys(airports[i]);
                buttonInputToCollections[i].Click();
                inputToCollections[i].SendKeys(airports[i + 1]);
                tableDate[i].Click();
                ButtonSubmitDate.Click();
            }
            MultiCitySearch.Click();
        }
    }
}
