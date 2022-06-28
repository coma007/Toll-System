﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TollSystem.Core.Entities
{
    class Staff
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public Credentials Credentials { get; set; }


        public Staff()
        {

        }

        public Staff(string firstName, string lastName, double salary, Credentials credentials)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Credentials = credentials;
        }

    }
}
