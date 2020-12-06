using System;
using TechTalk.SpecFlow;
using testautomation.Drivers;
using FluentAssertions;

namespace testautomation.Steps
{
    [Binding]
    public class CreateAnAccountSteps
    {
        private readonly HomePageDriver homePageDriver;
        private readonly AuthenticationPageDriver authenticationPageDriver;
        private readonly CreateAnAccountPageDriver createAnAccountPageDriver;

        public CreateAnAccountSteps(HomePageDriver homePageDriver, CreateAnAccountPageDriver createAnAccountPageDriver, AuthenticationPageDriver authenticationPageDriver)
        {
            this.homePageDriver = homePageDriver;
            this.authenticationPageDriver = authenticationPageDriver;
            this.createAnAccountPageDriver = createAnAccountPageDriver;            
        }

        [Given(@"the create an account page is shown for the shopper ""(.*)""")]
        public void GivenTheCreateAnAccountPageIsShownForTheShopper(string email)
        {
            authenticationPageDriver.GoToAuthenticationPage();
            authenticationPageDriver.RegisterEmailAddress(email);
            createAnAccountPageDriver.GetEmail().Should().Be(email);
        }
        
        [When(@"the shopper enters the first name ""(.*)""")]
        public void WhenTheShopperEntersTheFirstName(string firstName)
        {
            createAnAccountPageDriver.SetFirstName(firstName).Should().BeTrue();
        }
        
        [When(@"the shopper enters the last name ""(.*)""")]
        public void WhenTheShopperEntersTheLastName(string lastName)
        {
            createAnAccountPageDriver.SetLastName(lastName).Should().BeTrue();
        }
        
        [When(@"the shopper enters the password ""(.*)""")]
        public void WhenTheShopperEntersThePassword(string password)
        {
            createAnAccountPageDriver.SetPassword(password).Should().BeTrue();
        }
        
        [When(@"the shopper enters the date of birth ""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenTheShopperEntersTheDateOfBirth(string day, string month, string year)
        {
            createAnAccountPageDriver.SetDateOfBirth(day, month, year).Should().BeTrue();
        }
        
        [When(@"the shopper sets the newsletters to ""(.*)""")]
        public void WhenTheShopperSetsTheNewslettersTo(string isOn)
        {
            createAnAccountPageDriver.SetNewsLetter(isOn);
        }
        
        [When(@"the shopper set the offers to ""(.*)""")]
        public void WhenTheShopperSetTheOffersTo(string isOn)
        {
            createAnAccountPageDriver.SetOffers(isOn);
        }
        
        [When(@"the shopper enters the company ""(.*)""")]
        public void WhenTheShopperEntersTheCompany(string company)
        {
            createAnAccountPageDriver.SetCompany(company).Should().BeTrue();
        }
        
        [When(@"the shopper enters the address line ""(.*)""")]
        public void WhenTheShopperEntersTheAddressLine(string addressLine1)
        {
            createAnAccountPageDriver.SetAddressLine1(addressLine1).Should().BeTrue();
        }
        
        [When(@"the shopper enters the city ""(.*)""")]
        public void WhenTheShopperEntersTheCity(string city)
        {
            createAnAccountPageDriver.SetCity(city).Should().BeTrue();
        }
        
        [When(@"the shopper enters the state ""(.*)""")]
        public void WhenTheShopperEntersTheState(string state)
        {
            createAnAccountPageDriver.SetState(state).Should().BeTrue();
        }
        
        [When(@"the shopper enters the country ""(.*)""")]
        public void WhenTheShopperEntersTheCountry(string country)
        {
            createAnAccountPageDriver.SetCountry(country).Should().BeTrue();
        }
        
        [When(@"the shopper enters the zip ""(.*)""")]
        public void WhenTheShopperEntersTheZip(string zip)
        {
            createAnAccountPageDriver.SetZip(zip).Should().BeTrue();
        }
        
        [When(@"the shopper enters the info ""(.*)""")]
        public void WhenTheShopperEntersTheInfo(string additionalInformation)
        {
            createAnAccountPageDriver.SetAdditionalInformation(additionalInformation).Should().BeTrue();
        }
        
        [When(@"the shopper enters the home ""(.*)""")]
        public void WhenTheShopperEntersTheHome(string home)
        {
            createAnAccountPageDriver.SetHomeNumber(home).Should().BeTrue();
        }
        
        [When(@"the shopper enters the mobile ""(.*)""")]
        public void WhenTheShopperEntersTheMobile(string mobile)
        {
            createAnAccountPageDriver.SetMobileNumber(mobile).Should().BeTrue();
        }
        
        [When(@"the shopper enters the alias ""(.*)""")]
        public void WhenTheShopperEntersTheAlias(string alias)
        {
            createAnAccountPageDriver.SetAlias(alias).Should().BeTrue();
        }
        
        [When(@"the shopper registers")]
        public void WhenTheShopperRegisters()
        {
            createAnAccountPageDriver.SelectRegister();
        }
        
        [Then(@"the shopper is shown the myaccount page for ""(.*)""")]
        public void ThenTheShopperIsShownTheMyaccountPageFor(string accountName)
        {
            homePageDriver.isLoggedInAs().Should().Be(accountName);
        }
    }
}
