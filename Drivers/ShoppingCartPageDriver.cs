using System;
using System.Collections.Generic;
using System.Text;
using testautomation.PageObjects;

namespace testautomation.Drivers
{
   public class ShoppingCartPageDriver
   {
        public void GoToShoppingCart()
        {
            var shoppingCartPageObject = new ShoppingCartPageObject();
            shoppingCartPageObject.GoToShoppingCart();
        }

        public void RemoveProductFromShoppingCart(string product)
        {
            var shoppingCartPageObject = new ShoppingCartPageObject();
            shoppingCartPageObject.RemoveProductFromShoppingCart(product);
        }

        public bool isShoppingCartEmpty()
        {
            var shoppingCartPageObject = new ShoppingCartPageObject();
            return shoppingCartPageObject.isShoppingCartEmpty();
        }

        public bool isShoppingCartShown()
        {
            var shoppingCartPageObject = new ShoppingCartPageObject();
            return shoppingCartPageObject.isShoppingCartShown();
        }

        public bool isProductInCart(string product)
        {
            var shoppingCartPageObject = new ShoppingCartPageObject();
            return shoppingCartPageObject.isProductInCart(product);
        }
    }


}
