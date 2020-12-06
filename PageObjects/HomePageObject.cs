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

        public void SelectProductMenuItem(string parent, string child, string grandChild)
        {
            //Select Parent Menu Item

            //Select Child Menu Item

            //Select Grand Child Menu Item
        }

        public void SelectInformationMenuItem(string child)
        {
            //select child item of Informtion menu in page footer
        }

        public bool isHomePageShown()
        {
            //Check URL and return true if URL is home page URL http://automationpractice.com/index.php
            return true;
        }

        public string isLoggedInAs()
        {
            //Check menu bar for account name
            return "name";
        }

    }
}
