using ddfApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace ddfApi.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController: Controller
    {
        private static List<Customer> _customers = new List<Customer> {
                        new Customer{
                               Id=Guid.NewGuid(),
                                Age=25,
                                FirstName="Bla",
                                LastName="Blubb"
                        },
                        new Customer{
                               Id=Guid.NewGuid(),
                                Age=25,
                                FirstName="Hey",
                                LastName="Ho"
                        }
            };
        /// <summary>
        /// Fetches all customers
        /// </summary>
        /// <returns>A collection of customers</returns>
        [HttpGet]
        public IEnumerable<Customer> GetAll()
        {
            return _customers;

        }
    }
}
