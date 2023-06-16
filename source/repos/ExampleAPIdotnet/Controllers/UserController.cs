using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static ExampleAPIdotnet.Controllers.CartController;

namespace ExampleAPIdotnet.Controllers
{
    [ApiController]
    [Route("[controller]/User")]
    public class UserController : Controller
    {
        // POST: UserController/CreateUsers
        [HttpPost("~/CreateUser")]
        public User? CreateUser(User user)
        {
            try
            {
                return user;
            }
            catch
            {
                return null;
            }
        }

        // GET: ItemController/GetItem
        [HttpGet("~/GetUser")]
        public User GetUser(long id)
        {
            return new User();
        }

        // POST: ItemController/PutItem
        [HttpPut("~/PutUser")]
        public User EditUser(User user)
        {
            try
            {
                return user;
            }
            catch
            {
                return user;
            }
        }

        // GET: ItemController/DeleteItem
        [HttpDelete("~/DeleteUser")]
        public User DeleteUser(long id)
        {
            return new User();
        }
    }

    public class User
    {
        private long Id { get; set; }
        private String FirstName { get; set; }
        private String LastName { get; set; }
        private String Email { get; set; }
        private string Password { get; set; }
        private DateTime DateJoined { get; set; }
        private List<Cart> Purchases { get; set; }
        private List<Card> Cards { get; set; }

        public User()
        {
            Id = 0;
            FirstName = "John";
            LastName = "Doe";
            Email = "example@mail.not";
            Password = "password";
            DateJoined = DateTime.Now;
            Purchases = new List<Cart>();
            Cards = new List<Card>();
        }

        public User(long id, String firstName, String lastName, String email, string password, DateTime dateJoined, List<Cart> purchases, List<Card> cards)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            DateJoined = dateJoined;
            Purchases = purchases;
            Cards = cards;
        }

        public Boolean addCard(Card card)
        {
            if (card == null)
            {
                return false;

            }

            Cards.Add(card);
            return true;
        }

        public Boolean removeCard(Card card)
        {
            if (card == null ||
                !Cards.Contains(card))
            {
                return false;

            }

            Cards.Remove(card);
            return true;
        }



        public Boolean updateCard(Card card)
        {
            if (card == null)
            {
                return false;
            }

            bool found = false;
            for (int i = 0; i < Cards.Count; i++)
            {
                if (Cards[i].Id == card.Id)
                {
                    Cards[i] = card;
                    found = true;
                }
            }

            return found;
        }

        public Boolean addPurchase(Cart cart)
        {
            if (cart == null)
            {
                return false;

            }
            Purchases.Add(cart);
            return true;
        }

        public Boolean updatePurchase(Cart cart)
        {
            if (cart == null)
            {
                return false;

            }

            bool found = false;
            for (int i = 0; i < Purchases.Count; i++)
            {
                if (Purchases[i].Id == cart.Id)
                {
                    Purchases[i] = cart;
                    found = true;
                }
            }

            return found;
        }

        public Boolean deletePurchase(Cart cart)
        {
            if (cart == null)
            {
                return false;

            }
            Purchases.Remove(cart);
            return true;
        }
    }
}
