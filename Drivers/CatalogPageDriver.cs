﻿using System;
using System.Collections.Generic;
using System.Text;
using testautomation.PageObjects;

namespace testautomation.Drivers
{
    public class CatalogPageDriver
    {

        public bool isCategoryShown(string category)
        {
            var catalogPageObject = new CatalogPageObject();
            return catalogPageObject.isCategoryShown(category);
        }

        public int GetCurrentProductCount()
        {
            var catalogPageObject = new CatalogPageObject();
            return catalogPageObject.CurrentProductCount();
        }

        public void SetUpperPriceRange(string upper)
        {
            var catalogPageObject = new CatalogPageObject();
            catalogPageObject.SetUpperPriceRange(upper);                    
        }

        public void SetLowerPriceRange(string lower)
        {
            var catalogPageObject = new CatalogPageObject();
            catalogPageObject.SetLowerPriceRange(lower);
        }

        public string GetUpperPriceRange()
        {
            var catalogPageObject = new CatalogPageObject();
            return catalogPageObject.GetUpperPriceRange();            
        }

        public string GetLowerPriceRange()
        {
            var catalogPageObject = new CatalogPageObject();
            return catalogPageObject.GetLowerPriceRange();
        }

        public double[] GetProductPrices()
        {
            var catalogPageObject = new CatalogPageObject();
            return catalogPageObject.GetProductPrices();
        }

        public void AddProductToCart(string product, string catalogOption)
        {
            var catalogPageObject = new CatalogPageObject();
            catalogPageObject.AddProductToCart(product);

            switch (catalogOption.ToString())
            {
                case "continueshopping" :
                    catalogPageObject.ContinueShopping();
                    break;
                case "gotocart":
                    catalogPageObject.GoToCart();
                    break;

                default:
                    catalogPageObject.ContinueShopping();
                    break;
            }
            
        }
            
    }
}
