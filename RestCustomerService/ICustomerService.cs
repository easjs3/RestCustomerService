using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RestCustomerService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICustomerService
    {
        //vi laver en OPC den skal indeholde nogle metoder fra CRUD her er det GET så vi kan hente ting.
        //vi vil gerne ha det som Json 
        [OperationContract]
        [WebInvoke(
            Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "customers/"
            )]
        IList<Customer> GetCustomers();


        [OperationContract]
        [WebInvoke(
            Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Customers/{id}"
        )]
        Customer GetCustomerID(string id);

    }
}
