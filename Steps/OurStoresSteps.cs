using System;
using TechTalk.SpecFlow;
using testautomation.Drivers;
using FluentAssertions;

namespace testautomation.Steps
{
    [Binding]
    public class OurStoresSteps
    {
        private readonly HomePageDriver homePageDriver;
        private readonly OurStoresPageDriver ourStorePageDriver;

        public OurStoresSteps(HomePageDriver homePageDriver, OurStoresPageDriver ourStorePageDriver)
        {
            this.homePageDriver = homePageDriver;
            this.ourStorePageDriver = ourStorePageDriver;
        }

        [Given(@"the our stores page is displayed")]
        public void GivenTheOurStoresPageIsDisplayed()
        {
            homePageDriver.SelectInformationMenuItem("our stores");
            ourStorePageDriver.isOurStoresPageShown().Should().BeTrue();
        }
        
        [When(@"the shopper scroll the map ""(.*)"" by ""(.*)""")]
        public void WhenTheShopperScrollTheMapBy(string direction, string steps)
        {
            ourStorePageDriver.ScrollMap(direction, steps);
        }        
           
        [Then(@"the maps shows the correct location ""(.*)""")]
        public void ThenTheMapsShowsTheCorrectLocation(string filePath)
        {
            ourStorePageDriver.CompareImages(filePath).Should().BeTrue();
        }
    }
}
