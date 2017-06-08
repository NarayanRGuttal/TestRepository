using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FirstAPII.Models;

namespace FirstAPII.Controllers
{
    public class CustomerController : ApiController
    {
        public IHttpActionResult GetCustomers()
        {
            Customer customer = new Models.Customer();
            customer.Name = "Narayan";
            customer.CustID = "123";

            return Ok(customer);
        }
        
    }
}
