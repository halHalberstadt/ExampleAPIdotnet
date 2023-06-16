using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleAPIdotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartController : Controller
    {
        [HttpGet("~/AddCart")]
        public Cart AddCart(long userId, Cart cart)
        {
            return cart;
        }
        [HttpPost("~/GetCart")]
        public Cart GetCart(long id)
        {
            return new Cart();
        }
        [HttpGet("~/DeleteCart")]
        public Cart DeleteCart(long id)
        {
            return new Cart();
        }
    }
}
