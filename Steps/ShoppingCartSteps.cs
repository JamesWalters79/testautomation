using System;
using TechTalk.SpecFlow;
using testautomation.Drivers;
using FluentAssertions;

namespace testautomation.Steps
{
    [Binding]
    public class ShoppingCartSteps
    {       
       
        private readonly HomePageDriver homePageDriver;
        private readonly CatalogPageDriver catalogPageDriver;
        private readonly ShoppingCartPageDriver shoppingCartPageDriver;

        public ShoppingCartSteps(HomePageDriver homePageDriver, CatalogPageDriver catalogPageDriver, ShoppingCartPageDriver shoppingCartPageDriver)
        {
            this.homePageDriver = homePageDriver;
            this.catalogPageDriver = catalogPageDriver;
            this.shoppingCartPageDriver = shoppingCartPageDriver;
        }

        [Given(@"a ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" is added to the shopping cart")]
        public void GivenAIsAddedToTheShoppingCart(string parent, string child, string grandChild, string product)
        {
            homePageDriver.GoToHomePage();
            homePageDriver.SelectMenuItem(parent, child, grandChild);
            catalogPageDriver.AddProductToCart(product, "continueshopping");
            shoppingCartPageDriver.GoToShoppingCart();
            shoppingCartPageDriver.isProductInCart(product).Should().BeTrue();
            shoppingCartPageDriver.isShoppingCartEmpty().Should().BeFalse();
        }
        
        [When(@"the shopper views the shopping cart")]
        public void WhenTheShopperViewsTheShoppingCart()
        {
            shoppingCartPageDriver.GoToShoppingCart();
            shoppingCartPageDriver.isShoppingCartShown().Should().BeTrue();
        }
        
        [When(@"the shopper removes the ""(.*)"" from the shopping cart")]
        public void WhenTheShopperRemovesTheFromTheShoppingCart(string product)
        {
            shoppingCartPageDriver.RemoveProductFromShoppingCart(product);
            shoppingCartPageDriver.isProductInCart(product).Should().BeFalse();
        }
        
        [Then(@"the ""(.*)"" is removed from shopping cart")]
        public void ThenTheIsRemovedFromShoppingCart(string product)
        {
            shoppingCartPageDriver.isProductInCart(product).Should().BeFalse();
        }
        
        [Then(@"the shopping cart is empty")]
        public void ThenTheShoppingCartIsEmpty()
        {
            shoppingCartPageDriver.isShoppingCartEmpty().Should().BeTrue();
        }
    }
}
