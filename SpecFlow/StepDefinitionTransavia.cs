using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;
using UnitTests;
using OpenQA.Selenium;

// *** NOT USED ***
//[TestFixture]
//public class TestCases
//{
    // Set up some test data.
    // ....


//    [SetUp]
 //   public void TestInit()
 //   {

 //   }

 //   [Test]
 //   public void TestDoSomething1()
  //  {

  //  }

 //   [Test]
  //  public void TestDoSomething2()
  //  {

  //  }

  //  [Test]
  //  public void TestDoSomething3()
  //  {

  //  }
//}
// *** NOT USED ***

namespace SpecFlow
{
    [Binding, Scope(Tag = "Automated")]
    public class StepDefinitionTransavia
    {
        static IWebDriver globalDriver;

        // All input data.
        public string addressHomePage { set; private get; }
        public string departureAirport { set; private get; }
        public string destination { set; private get; }
        public string departureDate { set; private get; }
        public string returnDate { set; private get; }
        public int numberOfAdults { set; private get; }
        public int numberOfKids { set; private get; }
        public int numberOfBabies { set; private get; }
        public string includingBlueMiles { set; private get; }

        [BeforeScenario("TestInitialize")]
        public void TestInitialize()
        {
            globalDriver = SF.StartDriver_SF();
        }

        [Given(@"I am a user who wants to book a flight at ""(.*)""")]
        public void GivenIAmAUserWhoWantsToBookAFlightAt(string url)
        {
            // Get data.
            addressHomePage = url;
           
            // Use it.
            SF.NavigateToUrl_SF(globalDriver, addressHomePage);
        }

        [Given(@"I have entered departure airport ""(.*)"" and destination ""(.*)""")]
        public void GivenIHaveEnteredDepartureAirportAndDestination(string depart, string dest)
        {
            // Get data.
            departureAirport = depart;
            destination = dest;

            // Use it.
            SF.SendKeysToElementById_SF(globalDriver, "routeSelection_DepartureStation-input", departureAirport);
            SF.ClearAndSendKeysToElementById_SF(globalDriver, "routeSelection_ArrivalStation-input", destination);
            SF.SendKeysToElementById_SF(globalDriver, "routeSelection_ArrivalStation-input", Keys.Tab);
        }

        [Given(@"I have entered departure date ""(.*)"" and return date ""(.*)""")]
        public void GivenIHaveEnteredDepartureDateAndReturnDate(string departDt, string returnDt)
        {
            // Get data.
            departureDate = departDt;
            returnDate = returnDt;

            // Use it.
            SF.SendKeysToElementById_SF(globalDriver, "dateSelection_OutboundDate-datepicker", departureDate);
            SF.SendKeysToElementById_SF(globalDriver, "dateSelection_OutboundDate-datepicker", Keys.Tab);
            if (returnDate.Equals("")) // No return date? Then make sure check box 'Return on' is not selected.
            {
                if (SF.CheckBoxIsCheckedById_SF(globalDriver, "dateSelection_IsReturnFlight"))
                    SF.ClickElementByXPath_SF(globalDriver, "//*[@id='desktop']/section/div[2]/div[2]/div/div/div[2]/div/div[1]/label/span"); // No return! Just one way ticket.
            }
            else
            {
                SF.ClearAndSendKeysToElementById_SF(globalDriver, "dateSelection_IsReturnFlight-datepicker", returnDate);
            }
        }

        [Given(@"I have entered number of travellers (.*) adults, (.*) kids, (.*) babies and including blue miles ""(.*)""")]
        public void GivenIHaveEnteredNumberOfTravellersAndIncludingBlueMiles(int numOfAdults, int numOfKids, int numOfBabies, string inclBlueMiles)
        {
            // Get data.
            numberOfAdults = numOfAdults;
            numberOfKids = numOfKids;
            numberOfBabies = numOfBabies;
            includingBlueMiles = inclBlueMiles;

            // Use it.
            SF.ClickElementById_SF(globalDriver, "booking-passengers-input"); //  Open pop up.

            for (int i = 1; numberOfAdults > i; i++)
                SF.ClickElementByXPath_SF(globalDriver, "//*[@id='desktop']/section/div[2]/div[3]/div/div[2]/div[2]/div[1]/div[1]/div/div/div[2]/div/div/button[2]"); //  Click number of travellers: adults.
            for (int i = 1; i == numberOfKids; i++)
                SF.ClickElementByXPath_SF(globalDriver, "//*[@id='desktop']/section/div[2]/div[3]/div/div[2]/div[2]/div[1]/div[2]/div/div/div[2]/div/div/button[2]"); //  Click number of travellers: kids.
            for (int i = 1; i == numberOfBabies; i++)
                SF.ClickElementByXPath_SF(globalDriver, "//*[@id='desktop']/section/div[2]/div[3]/div/div[2]/div[2]/div[1]/div[3]/div/div/div[2]/div/div/button[2]"); //  Click number of travellers: babies.

            SF.ClickElementByXPath_SF(globalDriver, "//button[@class='button button-secondary close']"); //  Click Save.

            // Blue Miles?
            if (includingBlueMiles.Equals("yes"))
            {
                if (!SF.CheckBoxIsCheckedById_SF(globalDriver, "flyingBlueSearch_FlyingBlueSearch"))
                {
                    SF.ClickElementByXPath_SF(globalDriver, "//*[@id='desktop']/section/div[2]/div[4]/div/div/label"); // Yes Blue Miles.
                }
            }
            else
            {
                if (SF.CheckBoxIsCheckedById_SF(globalDriver, "flyingBlueSearch_FlyingBlueSearch"))
                {
                    SF.ClickElementByXPath_SF(globalDriver, "//*[@id='desktop']/section/div[2]/div[4]/div/div/label"); // No Blue Miles.
                }
            }
        }

        [When(@"I press the search button")]
        public void WhenIPressTheSearchButton()
        {
           SF.ClickElementByXPath_SF(globalDriver, "//*[@id='desktop']/section/div[3]/div/button");
        }

        [Then(@"I will see a list of possible flights on page ""(.*)""")]
        public void ThenIWillSeeAListOfPossibleFlightsOnPage(string expPageHeaderFlightsPage)
        {
            string pageHeaderText = SF.GetElementTextByXPath_SF(globalDriver, "//*[@id='top']/div/div/div[3]/section/section/div/div[1]/div[1]/div/div[1]/h2");
            Console.Write("Header: "+ pageHeaderText);

            // Check page is opened.
            if (pageHeaderText.Contains(expPageHeaderFlightsPage))
            {
                Console.Write("\nTest successfull");
                //Assert.Pass();
            }
            else
            {
                Console.Write("\nTest FAILED!");
                //Assert.Fail();
            }

            // Go back.
            //globalDriver.Navigate().GoToUrl(addressHomePage);

            // End test.
            // SF.StopDriver_SF(globalDriver);
        }
    }

    [Binding, Scope(Tag = "Manual")]
    public class StepDefinitionTransaviaManual
    {
        // All are empty. (Manual tests.)

        [Given(@"I am a user who wants to book a flight at ""(.*)""")]
        public void GivenIAmAUserWhoWantsToBookAFlightAt(string url)
        {
        }

        [Given(@"I have entered departure airport ""(.*)"" and destination ""(.*)""")]
        public void GivenIHaveEnteredDepartureAirportAndDestination(string depart, string dest)
        {
        }

        [Given(@"I have entered departure date ""(.*)"" and return date ""(.*)""")]
        public void GivenIHaveEnteredDepartureDateAndReturnDate(string departDt, string returnDt)
        {
        }

        [Given(@"I have entered number of travellers (.*) adults, (.*) kids, (.*) babies and including blue miles ""(.*)""")]
        public void GivenIHaveEnteredNumberOfTravellersAndIncludingBlueMiles(int numOfAdults, int numOfKids, int numOfBabies, string inclBlueMiles)
        {
        }

        [When(@"I press the search button")]
        public void WhenIPressTheSearchButton()
        {
        }

        [Then(@"I will see a list of possible flights on page ""(.*)""")]
        public void ThenIWillSeeAListOfPossibleFlightsOnPage()
        {
        }
    }
}
