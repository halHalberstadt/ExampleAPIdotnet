using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleAPIdotnet.Controllers
{
    [ApiController]
    [Route("[controller]/Card")]
    public class CardController : Controller
    {
        [HttpPost("~/AddCard")]
        public Card AddCard(long userId, Card card)
        {
            return card;
        }

        [HttpGet("~/GetCard")]
        public Card GetCard(long id)
        {
            return new Card();
        }

        [HttpPut("~/UpdateCard")]
        public Card UpdateCart(Card card)
        {
            return new Card();
        }

        [HttpDelete("~/DeleteCard")]
        public Card DeleteCard(long id)
        {
            return new Card();
        }
    }
    public class Card
    {
        public long Id { get; set; }
        public string NameOnCard { get; set; }
        public long CardNumber { get; set; }
        public uint CardExpiration { get; set; } // in the form 0,dd0,mm0y,yyy 
        public ushort Zipcode { get; set; }
        public

        Card()
        {
            Id = 0;
            NameOnCard = "John Doe";
            CardNumber = 0;
            CardExpiration = 0;
            Zipcode = 0;
        }

        public Card(long id, string nameOnCard, long cardNumber, uint cardExpiration, ushort zipcode)
        {
            Id = id;
            NameOnCard = nameOnCard;
            CardNumber = cardNumber;
            CardExpiration = cardExpiration;
            Zipcode = zipcode;
        }

    }

}
