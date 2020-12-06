using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testautomation.PageObjects
{
    class HomePageObject
    {
        public void GoToHomePage()
        {
            //Navigate to the HomePage
        }

        public void SelectMenuItem(string parent, string child, string grandChild)
        {
            //Select Parent Menu Item

            //Select Child Menu Item

            //Select Grand Child Menu Item
        }

        public bool isHomePageShown()
        {
            //Check URL and return true if URL is home page URL http://automationpractice.com/index.php
            return true;
        }

    }
}
