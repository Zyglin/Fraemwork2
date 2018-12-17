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
            homePage.ChoosePerson();
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
            homePage.ChoosePerson();
            homePage.SendMainForm();
        }

        public string FlightResultDuration()
        {
            ResultPage resultPage = new ResultPage();
            return resultPage.FlightDuration();
        }


    }
}

