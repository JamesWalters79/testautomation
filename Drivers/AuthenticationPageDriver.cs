using System;
using System.Collections.Generic;
using System.Text;
using testautomation.PageObjects;

namespace testautomation.Drivers
{
    public class AuthenticationPageDriver
    {

        public void GoToAuthenticationPage()
        {
            var authenticationPageObject = new AuthenticationPageObject();
            authenticationPageObject.GoToAuthenticationPage();
        }

        public void RegisterEmailAddress(string email)
        {
            var authenticationPageObject = new AuthenticationPageObject();            
            authenticationPageObject.EnterEmailAddress(email);
            authenticationPageObject.SelectCreateAnAccount();
        }
    }
}
