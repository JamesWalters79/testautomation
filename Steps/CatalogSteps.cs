using System;
using FluentAssertions;
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
            homePageDriver.GoToHomePage().Should().BeTrue();
        }
        
        [When(@"the shopper views the ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" collection")]
        public void WhenTheShopperViewsTheCollection(string p0, string p1, string p2, string p3)
        {
            homePageDriver.SelectMenuitem(p0, p1, p2);
            catalogPageDriver.isCategoryShown(p3).Should().BeTrue();
        }

        [Then(@"the shopper sees ""(.*)"" products in the collection")]
        public void ThenTheShopperSeesProductsInTheCollection(string p0)
        {
            catalogPageDriver.GetCurrentProductCount().Should().Equals(p0);
        }

        [When(@"the shopper sets the minimum price to ""(.*)""")]
        public void WhenTheShopperSetsTheMinimumPriceTo(string p0)
        {
            catalogPageDriver.SetLowerPriceRange(p0);
            catalogPageDriver.GetLowerPriceRange().Should().Equals(p0);
        }
        
        [When(@"the shopper sets the maximum price to ""(.*)""")]
        public void WhenTheShopperSetsTheMaximumPriceTo(string p0)
        {
            catalogPageDriver.SetUpperPriceRange(p0);
            catalogPageDriver.GetUpperPriceRange().Should().Equals(p0);
        }    
                
        [Then(@"the price for each product is less than ""(.*)""")]
        public void ThenThePriceForEachProductIsLessThan(int p0)
        {
            catalogPageDriver.GetProductPrices().Should().OnlyContain(price => price <= p0);
        }
        
        [Then(@"the price for eac product is greater than ""(.*)""")]
        public void ThenThePriceForEacProductIsGreaterThan(int p0)
        {
            catalogPageDriver.GetProductPrices().Should().OnlyContain(price => price >= p0);
        }
    }
}
