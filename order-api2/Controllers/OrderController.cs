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
        public IEnumerable<string> Get()
        {
            // Task.Delay(3000).Wait();
            return new[] {"Nick2的訂單", "Jeff2的訂單"};
            // throw new Exception("get some error");
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