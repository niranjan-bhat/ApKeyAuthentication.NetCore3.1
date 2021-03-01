using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApKeyAuthentication.Controllers
{
    [Route("[controller]")]
    public class ProductController : Controller
    {
        [Authorize(Roles = "manager,teamlead")]
        [HttpGet("getspecialproduct")]
        public IActionResult GetSpecialProduct()
        {
            return Ok();
        }

        [Authorize(Policy  = "employee")]
        [HttpGet]
        [Route("GetAllproduct")]
        public IActionResult Product()
        {
            return Ok();
        }

        [HttpGet]
        [Route("nosecret")]
        public IActionResult NoSecret()
        {
            return Ok();
        }

        [HttpGet]
        [Route("GetAllproducts")]
        [Authorize(Roles = "manager,teamlead,employee")]
        public IActionResult GetAllproducts()
        {
            return Ok();
        }
    }
}
