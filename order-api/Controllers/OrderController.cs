using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace order_api.Controllers
{
    [ApiController]
    public class OrderController : ControllerBase
    {
        // GET: api/orders
        [Route("api/orders")]
        [HttpGet]
        public  IEnumerable<string> Get()
        {
            return new string[] { "Nick的訂單", "Jeff的訂單" };
        }
        
        [Route("api/orders/{id}")]
        [HttpGet]
        public string Get(int id)
        {
            var order = id switch
            {
                1 => "Nick的訂單",
                2 => "Jeff的訂單",
                _ => "查無此訂單"
            };
            return order;
        }
    }
}