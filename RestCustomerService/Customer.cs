using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestCustomerService
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Year { get; set; }


        public Customer()
        {
            
        }

        public Customer(int id, string firstName, string lastName, int year)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Year = year;
        }

    }
}