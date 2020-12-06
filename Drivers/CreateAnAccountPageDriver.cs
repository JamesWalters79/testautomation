using System;
using System.Collections.Generic;
using System.Text;
using testautomation.PageObjects;

namespace testautomation.Drivers
{
    public class CreateAnAccountPageDriver
    {
        public string GetEmail()
        {
            var createAnAccountPageObject = new CreateAnAccountPageObject();
            return createAnAccountPageObject.GetEmail();
        }

        public void SetTitle(string title)
        {
            var createAnAccountPageObject = new CreateAnAccountPageObject();
            createAnAccountPageObject.SetTitle(title);
        }

        public bool SetFirstName(string firstname)
        {
            var createAnAccountPageObject = new CreateAnAccountPageObject();
            return createAnAccountPageObject.SetFirstName(firstname);
        }

        public bool SetLastName(string lastname)
        {
            var createAnAccountPageObject = new CreateAnAccountPageObject();
            return createAnAccountPageObject.SetLastName(lastname);
        }

        public bool SetPassword(string password)
        {
            var createAnAccountPageObject = new CreateAnAccountPageObject();
            return createAnAccountPageObject.SetPassword(password);
        }

        public bool SetDateOfBirth(string day, string month, string year)
        {
            var createAnAccountPageObject = new CreateAnAccountPageObject();
            createAnAccountPageObject.SetDateOfBirthDay(day);
            createAnAccountPageObject.SetDateOfBirthMonth(month);
            return createAnAccountPageObject.SetDateOfBirthYear(year);
        }

        public void SetNewsLetter(string newsletter)
        {
            var createAnAccountPageObject = new CreateAnAccountPageObject();
            createAnAccountPageObject.SetNewsLetter(newsletter);
        }

        public void SetOffers(string offers)
        {
            var createAnAccountPageObject = new CreateAnAccountPageObject();
            createAnAccountPageObject.SetOffers(offers);
        }

        public bool SetCompany(string company)
        {
            var createAnAccountPageObject = new CreateAnAccountPageObject();
            return createAnAccountPageObject.SetCompany(company);
        }

        public bool SetAddressLine1(string addressLine1)
        {
            var createAnAccountPageObject = new CreateAnAccountPageObject();
            return createAnAccountPageObject.SetAddressLine1(addressLine1);
        }

        public bool SetAddressLine2(string addressLine2)
        {
            var createAnAccountPageObject = new CreateAnAccountPageObject();
            return createAnAccountPageObject.SetAddressLine2(addressLine2);
        }

        public bool SetCity(string city)
        {
            var createAnAccountPageObject = new CreateAnAccountPageObject();
            return createAnAccountPageObject.SetCity(city);
        }

        public bool SetState(string state)
        {
            var createAnAccountPageObject = new CreateAnAccountPageObject();
            return createAnAccountPageObject.SetState(state);
        }

        public bool SetZip(string zip)
        {
            var createAnAccountPageObject = new CreateAnAccountPageObject();
            return createAnAccountPageObject.SetZip(zip);
        }

        public bool SetCountry(string country)
        {
            var createAnAccountPageObject = new CreateAnAccountPageObject();
            return createAnAccountPageObject.SetCountry(country);
        }

        public bool SetAdditionalInformation(string additionalInformation)
        {
            var createAnAccountPageObject = new CreateAnAccountPageObject();
            return createAnAccountPageObject.SetAdditionalInformation(additionalInformation);
        }

        public bool SetHomeNumber(string homePhone)
        {
            var createAnAccountPageObject = new CreateAnAccountPageObject();
            return createAnAccountPageObject.SetHomeNumber(homePhone);
        }
        public bool SetMobileNumber(string mobilePhone)
        {
            var createAnAccountPageObject = new CreateAnAccountPageObject();
            return createAnAccountPageObject.SetMobileNumber(mobilePhone);
        }

        public bool SetAlias(string alias)
        {
            var createAnAccountPageObject = new CreateAnAccountPageObject();
            return createAnAccountPageObject.SetAlias(alias);
        }

        public void SelectRegister()
        {
            var createAnAccountPageObject = new CreateAnAccountPageObject();
            createAnAccountPageObject.SelectRegister();
        }

    }
}
