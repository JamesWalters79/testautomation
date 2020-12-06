using System;
using System.Collections.Generic;
using System.Text;
using testautomation.PageObjects;

namespace testautomation.Drivers
{
    public class HomePageDriver
    {
        public bool GoToHomePage()
        {
            var homePageObject = new HomePageObject();
            homePageObject.GoToHomePage();
            return homePageObject.isHomePageShown();
        }

        public void SelectMenuItem(string parent, string child, string grandChild)
        {
            var homePageObject = new HomePageObject();
            homePageObject.SelectMenuItem(parent, child, grandChild);
        }

        public string isLoggedInAs()
        {
            var homePageObject = new HomePageObject();
            return homePageObject.isLoggedInAs();
        }
    }
}
