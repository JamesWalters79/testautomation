using System;
using System.Collections.Generic;
using System.Text;

namespace testautomation.PageObjects
{
    class CreateAnAccountPageObject
    {
        public bool isPageShown()
        {
            //returns true if URL is http://automationpractice.com/index.php?controller=authentication&back=my-account#account-creation
            return true;
        }

        public string GetEmail()
        {
            //returns true if email field is set to email
            return "email";
        }

        public bool SetTitle(string title)
        {
            //select title radio button

            //return true if field and page validation passes
            return true;
        }


        public bool SetFirstName(string firstname)
        {
            //enter first name in text control

            //return true if field validation passes
            return true;
        }

        public bool SetLastName(string lastname)
        {
            //enter last name in text control

            //return true if field validation passes
            return true;
        }

        public bool SetPassword(string password)
        {
            //enter password in text control

            //return true if field validation passes
            return true;
        }

        public bool SetDateOfBirthDay(string day)
        {
            //select day from drop down

            //return true if field and page validation passes
            return true;
        }

        public bool SetDateOfBirthMonth(string month)
        {
            //select month from drop down

            //return true if field and page validation passes
            return true;
        }

        public bool SetDateOfBirthYear(string year)
        {
            //select year from drop down

            //return true if field and page validation passes
            return true;
        }

        public void SetNewsLetter(string newsletter)
        {
            //toggle newsletter to correct state
        }

        public void SetOffers(string offers)
        {
            //toggle offers to correct state

        }

        public bool SetCompany(string company)
        {
            //enter the company in text control

            //return true if field and page validation passes
            return true;
        }

        public bool SetAddressLine1(string adress)
        {
            //enter address line 1 in text control

            //return true if field and page validation passes
            return true;
        }

        public bool SetAddressLine2(string adress)
        {
            //enter address line 2 in text control

            //return true if field and page validation passes
            return true;
        }

        public bool SetCity(string city)
        {
            //enter the city in text control

            //return true if field and page validation passes
            return true;
        }

        public bool SetState(string state)
        {
            //select the state from drop down

            //return true if field and page validation passes
            return true;
        }

        public bool SetZip(string zip)
        {
            //enter the zip in text control

            //return true if field and page validation passes
            return true;
        }

        public bool SetCountry(string country)
        {
            //select the country from dorp down

            //return true if field and page validation passes
            return true;
        }

        public bool SetAdditionalInformation(string adress)
        {
            //enter the additional information in text control

            //return true if field and page validation passes
            return true;
        }

        public bool SetHomeNumber(string home)
        {
            //enter the home number in text control

            //return true if field and page validation passes
            return true;
        }

        public bool SetMobileNumber(string mobile)
        {
            //enter the mobile number in text control

            //return true if field and page validation passes
            return true;
        }

        public bool SetAlias(string alias)
        {
            //enter the alias text in text control

            //return true if field and page validation passes
            return true;
        }

        public void SelectRegister()
        {
            //press the register button
        }
    }
}
