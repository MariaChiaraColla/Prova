using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Classi
{
    public class Employee
    {
        //Campi
        private string firstName;
        private string lastName;
        private string role;
        private string department;

        //Proprietà
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        //Metodi
        public string StampaEmployee()
        {
            return firstName + " " + lastName + " " + role + " " + department;
        }

    }
}
