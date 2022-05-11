using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RateLimit.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProdcut()
        {
            return Ok(new { Id = 1, Name = "Kalem", Price = 20 });
        }

        [HttpPost]
        public IActionResult SaveProduct()
        {
            return Ok(new {Status ="Success"});
        }
        [HttpPut]
        public IActionResult UpdateProduct()
        {
            return Ok();
        }

        // bu alan belirtilmez ise herhangi bir url de name alanını alamyız, yani içindeki parametre
        //GET: : : api/product/kalem/20
        [HttpGet("{name}/{price}")]
        public IActionResult GetProdcut(string name,int price)
        {
            return Ok(name);
        }
    }
}
