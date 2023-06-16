﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleAPIdotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
                return null;
            }
        }

        // GET: ItemController/GetItem
        [HttpPost("~/GetItem")]
        public Item GetItem(long id)
        {
            return new Item();
        }

        // POST: ItemController/PutItem
        [HttpPut("~/PutItem")]
        public bool EditItem(Item item)
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
        [HttpDelete("~/DeleteItem")]
        public bool DeleteItem(long id)
        {
            return false;
        }
    }
}
