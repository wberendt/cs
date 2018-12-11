using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RESTapiEx1.Models;

namespace RESTapiEx1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            using (DataContext myContext = new DataContext())
            {
                var customers = (from c in myContext.Customers select c).ToList();

                var result = new List<Customer>();
                foreach (var item in customers)
                {
                    result.Add(item);
                }
                return result;
            }
        }

        // GET api/values/5
        [HttpGet("{Id}")]
        public ActionResult<Customer> Get(int id)
        {
            using (DataContext myContext = new DataContext())
            {
                var customers = (from c in myContext.Customers where c.Id == id select c).ToList();

                if (customers.Any())
                {
                    return customers[0];
                }
                return new EmptyResult();
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Customer customer)
        {
            using (DataContext myContext = new DataContext())
            {
                //myContext.Customers.InsertOnSubmit(customer);
                // executes the commands to implement the changes to the database
                //myContext.SubmitChanges();
            }
        }

        // PUT api/values/5
        [HttpPut("{Id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{Id}")]
        public void Delete(int id)
        {
        }
    }
}
