using System;
using TechTalk.SpecFlow;
using testautomation.Drivers;

namespace testautomation.Steps
{
    [Binding]
    public class CatalogSteps
    {
        private readonly CatalogPageDriver catalogPageDriver;
        private readonly HomePageDriver homePageDriver;

        public CatalogSteps(CatalogPageDriver catalogPageDriver, HomePageDriver homePageDriver)
        {
            this.catalogPageDriver = catalogPageDriver;
            this.homePageDriver = homePageDriver;
        }

        [Given(@"the store home page is displayed")]
        public void GivenTheStoreHomePageIsDisplayed()
        {
            homePageDriver.GoToPage();
        }
        
        [When(@"the shopper views the ""(.*)"" ""(.*)"" ""(.*)"" collection")]
        public void WhenTheShopperViewsTheCollection(string p0, string p1, string p2)
        {
            
        }
        
        [When(@"the shopper sets the minimum price to ""(.*)""")]
        public void WhenTheShopperSetsTheMinimumPriceTo(string p0)
        {
            
        }
        
        [When(@"the shopper sets the maximum price to ""(.*)""")]
        public void WhenTheShopperSetsTheMaximumPriceTo(string p0)
        {
            
        }
        
        [Then(@"the shopper sees ""(.*)"" products in the collection")]
        public void ThenTheShopperSeesProductsInTheCollection(string p0)
        {
            
        }
        
        [Then(@"the price for each product is less than ""(.*)""")]
        public void ThenThePriceForEachProductIsLessThan(string p0)
        {
            
        }
        
        [Then(@"the price for eac product is greater than ""(.*)""")]
        public void ThenThePriceForEacProductIsGreaterThan(string p0)
        {
            
        }
    }
}
