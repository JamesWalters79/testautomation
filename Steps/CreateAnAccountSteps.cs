using System;
using TechTalk.SpecFlow;
using testautomation.Drivers;
using NUnit.Framework;

namespace testautomation.Steps
{
    [Binding]
    public class CreateAnAccountSteps
    {
        private readonly CreateAnAccountPageDriver createAnAccountPageDriver;
        private readonly AuthenticationPageDriver authenticationPageDriver;

        public CreateAnAccountSteps(CreateAnAccountPageDriver createAnAccountPageDriver, AuthenticationPageDriver authenticationPageDriver)
        {
            this.createAnAccountPageDriver = createAnAccountPageDriver;
            this.authenticationPageDriver = authenticationPageDriver;
        }

        [Given(@"the create an account page is shown for the shopper ""(.*)""")]
        public void GivenTheCreateAnAccountPageIsShownForTheShopper(string p0)
        {
            authenticationPageDriver.RegisterEmailAddress(p0);
        }
        
        [When(@"the shopper enters the first name ""(.*)""")]
        public void WhenTheShopperEntersTheFirstName(string p0)
        {
          
        }
        
        [When(@"the shopper enters the last name ""(.*)""")]
        public void WhenTheShopperEntersTheLastName(string p0)
        {
           
        }
        
        [When(@"the shopper enters the password ""(.*)""")]
        public void WhenTheShopperEntersThePassword(string p0)
        {
           
        }
        
        [When(@"the shopper enters the date of birth ""(.*)""")]
        public void WhenTheShopperEntersTheDateOfBirth(string p0)
        {
           
        }
        
        [When(@"the shopper sets the newsletters to ""(.*)""")]
        public void WhenTheShopperSetsTheNewslettersTo(string p0)
        {
           
        }
        
        [When(@"the shopper set the offers to ""(.*)""")]
        public void WhenTheShopperSetTheOffersTo(string p0)
        {
           
        }
        
        [When(@"the shopper enters the company ""(.*)""")]
        public void WhenTheShopperEntersTheCompany(string p0)
        {
           
        }
        
        [When(@"the shopper enters the address line ""(.*)""")]
        public void WhenTheShopperEntersTheAddressLine(string p0)
        {
           
        }
        
        [When(@"the shopper enters the city ""(.*)""")]
        public void WhenTheShopperEntersTheCity(string p0)
        {
           
        }
        
        [When(@"the shopper enters the state ""(.*)""")]
        public void WhenTheShopperEntersTheState(string p0)
        {
           
        }
        
        [When(@"the shopper enters the country ""(.*)""")]
        public void WhenTheShopperEntersTheCountry(string p0)
        {
           
        }
        
        [When(@"the shopper enters the zip ""(.*)""")]
        public void WhenTheShopperEntersTheZip(string p0)
        {
           
        }
        
        [When(@"the shopper enters the info ""(.*)""")]
        public void WhenTheShopperEntersTheInfo(string p0)
        {
           
        }
        
        [When(@"the shopper enters the home ""(.*)""")]
        public void WhenTheShopperEntersTheHome(string p0)
        {
           
        }
        
        [When(@"the shopper enters the mobile ""(.*)""")]
        public void WhenTheShopperEntersTheMobile(string p0)
        {
           
        }
        
        [When(@"the shopper enters the alias ""(.*)""")]
        public void WhenTheShopperEntersTheAlias(string p0)
        {
           
        }
        
        [When(@"the shopper registers")]
        public void WhenTheShopperRegisters()
        {
           
        }
        
        [Then(@"the shopper is shown the myaccount page for ""(.*)""")]
        public void ThenTheShopperIsShownTheMyaccountPageFor(string p0)
        {
           
        }
    }
}
