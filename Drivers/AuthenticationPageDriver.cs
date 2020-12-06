using System;
using System.Collections.Generic;
using System.Text;
using testautomation.PageObjects;

namespace testautomation.Drivers
{
    public class AuthenticationPageDriver
    {
        public void RegisterEmailAddress(string email)
        {
            var authenticationPageObject = new AuthenticationPageObject();

            authenticationPageObject.GoToPage();

            authenticationPageObject.RegisterEmailAddress(email);
        }
    }
}
