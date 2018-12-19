using Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Automation
{
    [TestFixture]
    class Tests
    {
        private Steps steps = new Steps();

        private const string fieldDirectionText = "Аэропорт Минск наци...";
        private const string informationTextAboutCityWhereBookTicket = "Cтамбул,Турция";
        private const string bookTickertext = " Забронировать перелёт";
        private const string durationFlightText = "Продолжительность рейса";
        private const string maxCountPeopleErrorText = "Максимальное количество пассажиров, за исключением младенцев, составляет 9 человек на внутренние рейсы, 7 человек на международные рейсы и 5 человек на премиальные рейсы.";
        private const string sameDateErrorText = "Departure and arrival points cannot be the same. Please change one.";
        private const string childsMoreThenAdultsErrorText = "Максимальное количество пассажиров, за исключением младенцев, составляет 9 человек на внутренние рейсы, 7 человек на международные рейсы и 5 человек на премиальные рейсы.";
        private const string flightMemverResultText = "Последнее обновление";
        private const string toBookTicket = "Забронировать";
        private const string flightNotFound = "Не найдено ни одного рейса по данному маршруту и на выбранную дату.Измените даты и повторите попытку или свяжитесь с нашим контакт-центром";
        private const string departureFlight = "РЕЙС ВЫЛЕТА";

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }

        //test 8
        [Test]
        public void  PopularSpecialOffer()
        {
            steps.SelectSuggestionsAndDirectionsLink();
            Assert.AreEqual(fieldDirectionText, steps.AutomaticTextAppearance());     
        }
        [Test]
        public void ThereIsInformationAboutTheCityAndTheOpportunityToBookaTicket()
        {
            steps.SelectnIstanbulToBook();
            Assert.AreEqual(informationTextAboutCityWhereBookTicket, steps.InformationAboutCity());
            Assert.AreEqual(bookTickertext, steps.InformationButtonBookTicketText());
        }
        //test 1
        [Test]
        public void AvailableFlights()
        {
            steps.FillingFormForTheSearchTicket();
            Assert.AreEqual(durationFlightText, steps.FlightResultDuration());
        }
        //test 2
        [Test]
        public void AvailableFlightsWithChilds()
        {
            steps.FillingFormForTheSearchTicketWith3Person();
            Assert.AreEqual(durationFlightText, steps.FlightResultDuration());
        }
        //test 3
        [Test]
        public void MaxCountPeopleOnTheOrder()
        {
            Assert.AreEqual(maxCountPeopleErrorText, steps.FillingFormForTheSearchTicketWith14Person());
        }
        // test 4
        [Test]
        public void SameDateError()
        {
            Assert.AreEqual(sameDateErrorText, steps.SameDate());
        }
        //test 5
        [Test]
        public void ChildsMoreThenAdults()
        {
            Assert.AreEqual(childsMoreThenAdultsErrorText, steps.ThreeAdultAndFiveChildInTicket());
        }
        //test 6
        [Test]
        public void MultiFlight()
        {
            steps.MultiFlightDeparture();
            Assert.AreEqual(departureFlight, steps.FlightDepartureCheck());
        }
        //test 7
        [Test]
        public void ChooseOfferSpechiel()
        {
            steps.ShowAllCompanies();
            Assert.AreEqual(toBookTicket, steps.ChooseSpechialOffers());
        }

        //test 9
        [Test]
        public void FindFlightMember()
        {
            steps.FindFlightMember();
            Assert.AreEqual(flightMemverResultText, steps.FlightResultDuration());
        }

        //test 10 
        [Test]
        public void NotFindFlight()
        {
            steps.FindFlight();
            Assert.AreEqual(flightNotFound, steps.FlightNotFoundError());
        }
    }
}
