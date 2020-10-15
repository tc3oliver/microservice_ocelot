using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace product_api.Controllers
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET: api/products
        [Route("api/products")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "iPhone 12 Pro", "MacBook Pro" };
        }

    }
}