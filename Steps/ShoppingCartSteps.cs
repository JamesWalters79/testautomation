using System;
using TechTalk.SpecFlow;
using testautomation.Drivers;

namespace testautomation.Steps
{
    [Binding]
    public class ShoppingCartSteps
    {
        private readonly ShoppingCartPageDriver shoppingCartPageDriver;
        
        public ShoppingCartSteps(ShoppingCartPageDriver shoppingCartPageDriver)
        {
            this.shoppingCartPageDriver = shoppingCartPageDriver;
        }

        [Given(@"a ""(.*)"" is added to the shopping cart")]
        public void GivenAIsAddedToTheShoppingCart(string p0)
        {
            
        }
        
        [When(@"the shopper views the shopping cart")]
        public void WhenTheShopperViewsTheShoppingCart()
        {
            
        }
        
        [When(@"the shopper removes the ""(.*)"" from the shopping cart")]
        public void WhenTheShopperRemovesTheFromTheShoppingCart(string p0)
        {
            
        }
        
        [Then(@"the ""(.*)"" is removed from shopping cart")]
        public void ThenTheIsRemovedFromShoppingCart(string p0)
        {
            
        }
        
        [Then(@"the shopping cart is empty")]
        public void ThenTheShoppingCartIsEmpty()
        {
            
        }
    }
}
