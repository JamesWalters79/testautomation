using System;
using System.Collections.Generic;
using System.Text;

namespace testautomation.PageObjects
{
    class ShoppingCartPageObject
    {
        public void GoToShoppingCart()
        {
            //navigate to the shopping cart
        }

        public void RemoveProductFromShoppingCart(string product)
        {
            //delete the product from the shopping cart
        }

        public bool isShoppingCartEmpty()
        {
            //Check for header that states cart is empty
            return true;
        }

        public bool isShoppingCartShown()
        {
            //Check URL is for shopping cart http://automationpractice.com/index.php?controller=order
            return true;
        }

        public bool isProductInCart(string product)
        {
            //checks the cart for the product

            //if cart is empty then product cannot be in cart
            if (isShoppingCartEmpty())
            {
                return false;
            }

            //if cart is not empty then check products in cart for product name
            if (!isShoppingCartEmpty())
            {
                return false;
            }

            return false;

        }
    }
}
