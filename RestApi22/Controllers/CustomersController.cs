using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApi22.Models;

namespace RestApi22.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private static readonly northwindContext db = new northwindContext();

        [HttpGet]
        public ActionResult GetAll()
        {
            var customers = db.Customers;
            return Ok(customers);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult GetOneCustomer(string id)
        {
            var asiakas = db.Customers.Find(id);
            if (asiakas == null)
                return BadRequest("Tällä id:llä ei löytynyt asiakasta");
            return Ok(asiakas);
        }

    }
}
