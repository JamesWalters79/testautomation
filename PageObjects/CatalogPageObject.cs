using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testautomation.PageObjects
{
    class CatalogPageObject
    {
        public void GoToPage(string producttype)
        {

        }

        public void SetPriceRange(string upper, string lower)
        {
            
        }

        public int CurrentProductCount()
        {
            return 3;
        }

        static string[] GetProductPrices()
        {
            string[] prices = { "$28.98", "$30.50", "$16.40" };
            return prices;
        }

        static string[] GetProductNames()
        {
            string[] prices = { "Printed Summer Dress", "Printed Summer Dress", "Printed Chiffon Dress" };
            return prices;
        }
    }
}
