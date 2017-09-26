using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestCustomerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestCustomerService.Tests
{
    [TestClass()]
    public class CustomerServiceTests
    {


        [TestMethod()]
        public void GetCustomersTest()
        {
            //bemærk denne test vil fejle hvis vi har mere end 2 men på nuværende tidspunkt har vi kun 2


            //arrange
            CustomerService service = new CustomerService();
            //act
            int minint = service.GetCustomers().Count;
            //assert
            Assert.AreEqual(2,minint);
        }
    }
}