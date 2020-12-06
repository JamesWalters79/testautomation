using System;
using TechTalk.SpecFlow;
using testautomation.Drivers;

namespace testautomation.Steps
{
    [Binding]
    public class OurStoresSteps
    {
        private readonly OurStoresPageDriver ourStorePageDriver;

        public OurStoresSteps(OurStoresPageDriver ourStorePageDriver)
        {
            this.ourStorePageDriver = ourStorePageDriver;
        }

        [Given(@"the our stores page is displayed")]
        public void GivenTheOurStoresPageIsDisplayed()
        {
           
        }
        
        [When(@"the shopper scroll the map ""(.*)"" by ""(.*)""")]
        public void WhenTheShopperScrollTheMapBy(string p0, string p1)
        {
           
        }
        
        [When(@"the shopper scrolls the map ""(.*)"" by ""(.*)""")]
        public void WhenTheShopperScrollsTheMapBy(string p0, string p1)
        {
           
        }
        
        [Then(@"the maps shows the correct location ""(.*)""")]
        public void ThenTheMapsShowsTheCorrectLocation(string p0)
        {
           
        }
    }
}
