using Framework.Page;
using OpenQA.Selenium;

namespace Framework
{
    class Steps
    {
        IWebDriver driver;

        public void InitBrowser()
        {
            driver = Instance.GetInstance();
        }

        public void CloseBrowser()
        {
            Instance.CloseBrowser();
        }

        //test
        public void SelectSuggestionsAndDirectionsLink()
        {
            HomePage homePage = new HomePage(driver);
            homePage.OpenPage();
            homePage.ClickOnTheSuggestionsAndDirectionsLink();
        }

        public string AutomaticTextAppearance()
        {
            SpecialOfferPage specialOfferPage = new SpecialOfferPage(driver);
            return specialOfferPage.AutoFieldDirectionResult();
        }

        public void SelectnIstanbulToBook()
        {
            SpecialOfferPage specialOfferPage = new SpecialOfferPage(driver);
            specialOfferPage.ClickOnIstanbulToBook();
        }

        public string InformationAboutCity()
        {
            InformationAboutCityAndBookTicketPage informationAboutTicket = new InformationAboutCityAndBookTicketPage(driver);
            return informationAboutTicket.InformationAboutCityWhereBookTicket.Text;
        }

        public string InformationButtonBookTicketText()
        {
            InformationAboutCityAndBookTicketPage informationAboutTicket = new InformationAboutCityAndBookTicketPage(driver);
            return informationAboutTicket.ButtonBookTicket.Text;
        }

        //test 1
        public void FillingFormForTheSearchTicket()
        {
            HomePage homePage = new HomePage(driver);
            homePage.OpenPage();
            homePage.AirportFlyFrom("mxp");
            homePage.AirportFlyTo("cdg");
            homePage.SelectDate();
            homePage.ChoosePersonButtonOK();
            homePage.SendMainForm();
        }

        public string FlightResultDuration()
        {
            ResultPage resultPage = new ResultPage();
            return resultPage.FlightDuration();
        }

        //test 2
        public void FillingFormForTheSearchTicketWith3Person()
        {
            HomePage homePage = new HomePage(driver);
            homePage.OpenPage();
            homePage.AirportFlyFrom("msq");
            homePage.AirportFlyTo("vko");
            homePage.SelectDateForSecondTest();
            homePage.ChooseChildAndInfant();
            homePage.ChoosePersonButtonOK();
            homePage.SendMainForm();
        }

        //test 3
        public string FillingFormForTheSearchTicketWith14Person()
        {
            HomePage homePage = new HomePage(driver);
            homePage.OpenPage();
            homePage.AirportFlyFrom("msq");
            homePage.AirportFlyTo("vko");
            homePage.SelectDateForThirdTest();
            homePage.Choose7AdultAnd7Child();
            homePage.ChoosePersonButtonOK();
            return homePage.MaxCountPeopleErrorInFrom();
        }

        //test 4
        public string SameDate()
        {
            HomePage homePage = new HomePage(driver);
            homePage.OpenPage();
            homePage.AirportFlyFrom("msq");
            homePage.AirportFlyTo("msq");
            homePage.SelectDate();
            return homePage.DateErorInForm();
        } 

        //test 5
        public string ThreeAdultAndFiveChildInTicket()
        {
            HomePage homePage = new HomePage(driver);
            homePage.OpenPage();
            homePage.AirportFlyFrom("msq");
            homePage.AirportFlyTo("vko");
            homePage.SelectDate();
            homePage.Choose3AdultsAnd5Child();
            return homePage.ChildCountErrorInForm();
        }
        //test 6
        public MultiFlightDeparture()
        {
            HomePage homePage = new HomePage(driver);
            homePage.OpenPage();
            homePage.SendMultiChoose();
        }

        public FlightDepartureCheck()
        {
            ResultPage resultPage = new ResultPage();
            return resultPage.DepartureFlightText();
        }
        //test 7
        public void ShowAllCompanies()
        {
            HomePage homePage = new HomePage(driver);
            homePage.OpenPage();
            homePage.CLickShowAllCompanies();           
        }

        public string ChooseSpechialOffers()
        {
            ResultPage resultPage = new ResultPage();
            return resultPage.FindSpechialOfferForFlight("lgw");
        }


        //test 9 
        public string FindFlightMember()
        {
            HomePage homePage = new HomePage(driver);
            homePage.OpenPage();
            homePage.FlightStatus();
        }

        public string FlightResultDuration()
        {
            ResultPage resultPage = new ResultPage();
            return resultPage.ResultFlightMember();
        }

        //test 10
        public string FindFlight()
        {
            HomePage homePage = new HomePage(driver);
            homePage.OpenPage();
            HomePage homePage = new HomePage(driver);
            homePage.OpenPage();
            homePage.AirportFlyFrom("msq");
            homePage.AirportFlyTo("vko");
            homePage.SelectDate();
            homePage.SendMainForm();
        }

        public string FlightNotFoundError()
        {
            ResultPage resultPage = new ResultPage();
            return resultPage.FlighNotFoundError();
        }
    }
}

