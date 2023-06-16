using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

namespace ExampleAPIdotnet.Controllers
{
    [ApiController]
    [Route("[controller]/Cart")]
    public class CartController : Controller
    {
        [HttpPost("~/AddCart")]
        public Cart AddCart(long userId, Cart cart)
        {
            return cart;
        }

        [HttpPut("~/AddToCart")]
        public bool AddToCart(long cartId, Item item)
        {
            return false;
        }

        [HttpPut("~/RemoveFromCart")]
        public bool RemoveFromCart(long cartId, Item item)
        {
            return false;
        }

        [HttpGet("~/GetCart")]
        public Cart GetCart(long id)
        {
            return new();
        }

        [HttpGet("~/GetCartItems")]
        public List<Item> GetCartItems(long id)
        {
            return new Cart().CartItems;
        }

        [HttpGet("~/GetCartTotal")]
        public double GetCartTotal(long id)
        {
            // Just for inital testing, needs to be replaced by database found cart
            Cart foundCart = new();
            double total = 0;
            foreach(Item item in foundCart.CartItems){
                total += item.Price;
            }
            return total;
        }

        [HttpDelete("~/DeleteCart")]
        public Cart DeleteCart(long id)
        {
            return new();
        }

        [HttpDelete("~/CompletePurchase")]
        public bool CompletePurchase(long cartId, long cardId, long userId)
        {
            Cart foundCart = new();
            Card foundCard = new();
            User foundUser = new();


            double total = 0;

            return false;
        }

        public class Cart
        {
            public long Id { get; set; }
            public long UserId { get; set; }
            public DateTime Date { get; set; }
            public double TotalPrice { get; set; }
            public double Tax { get; set; }
            public List<Item> CartItems { get; set; }
            public Card CardUsed { get; set; }

            public Cart()
            {
                Id = 0;
                UserId = 0;
                Date = new DateTime(2000, 1, 1, 0, 0, 0);
                TotalPrice = 0.0;
                Tax = 0.0;
                CartItems = new List<Item>
            {
                new Item(),
                new Item(1, 5, "A single five dollar item", "looks just like five dollars, but isn't recogized by the US treasury."),
                new Item(2, 1.75, "An overpoured dollar pancake", "we went a little overboard on this dollar pancake.")
            };
                CardUsed = new Card();
            }

            public Cart(long id, long userId, DateTime date, double totalPrice, double tax, List<Item> cartItems, Card cardUsed)
            {
                Id = id;
                UserId = userId;
                Date = date;
                TotalPrice = totalPrice;
                Tax = tax;
                CartItems = cartItems;
                CardUsed = cardUsed;
            }

            public override string ToString()
            {
                return $"Cart #{Id}";
            }

        }
    }
}
