using System;
using FluentAssertions;
using TechTalk.SpecFlow;
using testautomation.Drivers;

namespace testautomation.Steps
{
    [Binding]
    public class CatalogSteps
    {
        private readonly HomePageDriver homePageDriver;
        private readonly CatalogPageDriver catalogPageDriver;        

        public CatalogSteps(HomePageDriver homePageDriver, CatalogPageDriver catalogPageDriver)
        {
            this.catalogPageDriver = catalogPageDriver;
            this.homePageDriver = homePageDriver;
        }

        [Given(@"the store home page is displayed")]
        public void GivenTheStoreHomePageIsDisplayed()
        {
            homePageDriver.GoToHomePage().Should().BeTrue();
        }
        
        [When(@"the shopper views the ""(.*)"" ""(.*)"" ""(.*)"" collection")]
        public void WhenTheShopperViewsTheCollection(string parent, string child, string grandchild)
        {
            homePageDriver.SelectMenuItem(parent, child, grandchild);
            catalogPageDriver.isCategoryShown(grandchild).Should().BeTrue();
        }

        [Then(@"the shopper sees ""(.*)"" products in the collection")]
        public void ThenTheShopperSeesProductsInTheCollection(string product)
        {
            catalogPageDriver.GetCurrentProductCount().Should().Equals(product);
        }

        [When(@"the shopper sets the minimum price to ""(.*)""")]
        public void WhenTheShopperSetsTheMinimumPriceTo(string minimumPrice)
        {
            catalogPageDriver.SetLowerPriceRange(minimumPrice);
            catalogPageDriver.GetLowerPriceRange().Should().Equals(minimumPrice);
        }
        
        [When(@"the shopper sets the maximum price to ""(.*)""")]
        public void WhenTheShopperSetsTheMaximumPriceTo(string maximumPrice)
        {
            catalogPageDriver.SetUpperPriceRange(maximumPrice);
            catalogPageDriver.GetUpperPriceRange().Should().Equals(maximumPrice);
        }    
                
        [Then(@"the price for each product is less than ""(.*)""")]
        public void ThenThePriceForEachProductIsLessThan(int expectedPrice)
        {
            catalogPageDriver.GetProductPrices().Should().OnlyContain(price => price <= expectedPrice);
        }
        
        [Then(@"the price for eac product is greater than ""(.*)""")]
        public void ThenThePriceForEacProductIsGreaterThan(int expectedPrice)
        {
            catalogPageDriver.GetProductPrices().Should().OnlyContain(price => price >= expectedPrice);
        }
    }
}
