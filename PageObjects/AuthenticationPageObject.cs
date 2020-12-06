using System;
using System.Collections.Generic;
using System.Text;

namespace testautomation.PageObjects
{
    class AuthenticationPageObject
    {
        public void GoToAuthenticationPage()
        {
            //navigate to authentication page http://automationpractice.com/index.php?controller=authentication&back=my-account
        }

        public bool isShown()
        {
            //Check URL and return true if URL is like a catalog page URL http://automationpractice.com/index.php?controller=authentication&back=my-account
            return true;
        }


        public void EnterEmailAddress(string email)
        {
            //enter the email address
           
        }

        public void SelectCreateAnAccount()
        {
            //select the create an account button
        }

    }
}
