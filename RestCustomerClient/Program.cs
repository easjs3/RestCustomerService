using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RestCustomerClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //vi laver et foreach for alle vi har i vores liste og skriver dem ud
            foreach (var customer in GetCustomersAsync().Result)
                Console.WriteLine(customer.ToString());

            //her skriver vi id ud for person 1
            Console.WriteLine(GetCustomerIDAsync(1).Result);

            Console.ReadLine();
        }

        //denne metode vil hente alle fra vores liste og smide dem over i en liste og derfor retunere en liste
        //vi kan derfor bruge den i vores foreach
        private static async Task<IList<Customer>> GetCustomersAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string content = await client.GetStringAsync("http://localhost:52607/CustomerService.svc/customers/");
                IList<Customer> cList = JsonConvert.DeserializeObject<IList<Customer>>(content);
                return cList;
            }
        }

        //vi har lavet en ny liste der skal hente data fra en
        //vi vælger at bruge id og skal derfor sende det med som parameter
        //det vi får retuneret er en "person" altså en Customer
        private static async Task<Customer> GetCustomerIDAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                string content = await client.GetStringAsync($"http://localhost:52607/CustomerService.svc/customers/{id}");
                Customer person = JsonConvert.DeserializeObject<Customer>(content);
                return person;
            }
        }

    }
}
