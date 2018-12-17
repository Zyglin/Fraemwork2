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
    }
}
