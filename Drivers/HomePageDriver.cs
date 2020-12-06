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

        public void SelectProductMenuItem(string parent, string child, string grandChild)
        {
            var homePageObject = new HomePageObject();
            homePageObject.SelectProductMenuItem(parent, child, grandChild);
        }

        public void SelectInformationMenuItem(string child)
        {
            var homePageObject = new HomePageObject();
            homePageObject.SelectInformationMenuItem(child);
        }

        public string isLoggedInAs()
        {
            var homePageObject = new HomePageObject();
            return homePageObject.isLoggedInAs();
        }
    }
}
