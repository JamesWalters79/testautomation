using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testautomation.PageObjects
{
    class CatalogPageObject
    {
        public void GoToPage()
        {
            //Navigate to the Catalog Page
        }

        public void SetUpperPriceRange(string lower)
        {
            //Set upper price range

        }

        public void SetLowerPriceRange(string lower)
        {
            //Set lower price range

        }

        public string GetUpperPriceRange()
        {
            return "$30.50";
        }

        public string GetLowerPriceRange()
        {
            return "$30.50";
        }

        public bool isCategoryShown(string category)
        {
            //Check URL and return true if URL contains category page URL with correct category http://automationpractice.com/index.php?id_category=<category>&controller=category
            return true;
        }

        public bool isShown()
        {
            //Check URL and return true if URL is like a catalog page URL http://automationpractice.com/index.php?id_category=<category>&controller=category
            return true;
        }

        public int CurrentProductCount()
        {
            //Get the number of products from header and return

            return 3;
        }

        public double[] GetProductPrices()
        {
            //Get the price of each product shown and return array of prices (will have to trim to int)

            double[] prices = { 28.98, 30.50, 16.40 };
            return prices;
        }

        public string[] GetProductNames()
        {
            //get the name of each product shown and return array of product names

            string[] prices = { "Printed Summer Dress", "Printed Summer Dress", "Printed Chiffon Dress" };
            return prices;
        }
    }
}
