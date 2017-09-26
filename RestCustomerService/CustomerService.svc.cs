using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RestCustomerService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CustomerService : ICustomerService
    {


     private static List<Customer> cList = new List<Customer>(){new Customer(1,"navn","lastname",2000), new Customer(2, "navn2", "lastname2", 2222) };
     
        
        //vi skal finde ud af om denne metode er rigtig - vi har problemer med invoke men nettet virker samt client
        //fejl ved start i interface(ICustomerService)
        //grunden til vi har int x med er fordi Iterface gerne vil ha det er en string derfor laver vi string om til int
        //derefter linq til at finde person med det ID og return person (Customer)
        public Customer GetCustomerID(string id)
        {
            int x = Int32.Parse(id);

            var person = (from i in cList
                          where i.Id == x
                          select i).FirstOrDefault();

            return person;
        }

        //henter hele vores liste og retunere vores liste. 
        public IList<Customer> GetCustomers()
        {
            return  cList;
        }
    }
}
