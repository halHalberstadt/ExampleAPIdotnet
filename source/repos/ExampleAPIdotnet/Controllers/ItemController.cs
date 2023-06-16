using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleAPIdotnet.Controllers
{
    [ApiController]
    [Route("[controller]/Item")]
    public class ItemController : Controller
    {
        // POST: ItemController/Create
        [HttpPost("~/CreateItem")]
        public Item CreateItem(Item item)
        {
            try
            {
                return item;
            }
            catch
            {
                return item;
            }
        }

        // GET: ItemController/GetItem
        [HttpGet("~/GetItem")]
        public Item GetItem(long id)
        {
            return new Item();
        }

        // POST: ItemController/PutItem
        [HttpPut("~/PutItem")]
        public Item EditItem(Item item)
        {
            try
            {
                return item;
            }
            catch
            {
                return item;
            }
        }

        // GET: ItemController/DeleteItem
        [HttpDelete("~/DeleteItem")]
        public Item DeleteItem(long id)
        {
            return new Item();
        }
    }

    public class Item
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Item()
        {
            Id = 0;
            Price = 0;
            Name = "No name provided.";
            Description = "No description provided.";
        }

        public Item(long id, double price, string name, string description)
        {
            Id = id;
            Price = price;
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Id}:{Name} - ${Price}\n{Description}";
        }

    }
}
