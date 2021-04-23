using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookApp
{
    class Person
    {
        String firstName;
        String lastName;
        String address;
        String city;
        String state;
        String zip;
        String phoneNo;
        public Person(String firstName, String lastName, String address, String city, String state, String zip, String phoneNo)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.address = city;
            this.state = state;
            this.zip = zip;
            this.phoneNo = phoneNo;
        }
        public String getFirstName()
        {
            return this.firstName;
        }
        public String SetFirstName()
        {
            return this.firstName;
        }
        public String getLastName()
        {
            return this.lastName;
        }
        public String SetLastName()
        {
            return this.lastName;
        }
        public String getAddress()
        {
            return this.address;
        }
        public void SetAddress(String address)
        {
            this.address = address;
        }
        public String getState()
        {
            return this.state;
        }
        public void setState(String state)
        {
            this.state = state;
        }
        public String getCity()
        {
            return this.city;
        }
        public void setCity(String city)
        {
            this.city = city;
        }
        public String getzip()
        {
            return this.zip;
        }
        public void setZip(String zip)
        {
            this.zip = zip;
        }
        public String getPhoneNo()
        {
            return this.phoneNo;
        }
        public void setPhoneNo(String phoneNo)
        {
            this.phoneNo = phoneNo;
        }
    }
}
