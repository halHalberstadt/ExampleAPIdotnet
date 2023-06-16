using System.Collections;

namespace ExampleAPIdotnet
{
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
            CartItems = new List<Item>();
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
