using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleAPIdotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        // POST: ItemController/Create
        [HttpPost("~/CreateUser")]
        public Item CreateUser(Item item)
        {
            try
            {
                return item;
            }
            catch
            {
                return null;
            }
        }

        // GET: ItemController/GetItem
        [HttpPost("~/GetUser")]
        public Item GetUser(long id)
        {
            return new Item();
        }

        // POST: ItemController/PutItem
        [HttpPut("~/PutUser")]
        public bool EditUser(Item item)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }

        // GET: ItemController/DeleteItem
        [HttpDelete("~/DeleteUser")]
        public bool DeleteUser(long id)
        {
            return false;
        }
    }
}
