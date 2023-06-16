using System.Collections;

namespace ExampleAPIdotnet
{
    public class User
    {
        private long Id { get; set; }
        private String FirstName { get; set; }
        private String LastName { get; set; }
        private DateTime DateJoined { get; set; }
        private List<Cart> Purchases { get; set; }
        private List<Card> Cards { get; set; }

        public User()
        {
            Id = 0;
            FirstName = "John";
            LastName = "Doe";
            DateJoined = DateTime.Now;
            Purchases = new List<Cart>();
            Cards = new List<Card>();
        }

        public User(long id, String firstName, String lastName,  DateTime dateJoined, List<Cart> purchases, List<Card> cards)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DateJoined = dateJoined;
            Purchases = purchases;
            Cards = cards;
        }

        public Boolean addCard(Card card)
        {
            return false;
        }

        public Boolean removeCard(Card card)
        {
            return false;
        }

        public Boolean updateCard(Card card)
        {
            return false;
        }

        public Boolean addPurchase(Cart cart)
        {
            return false;
        }

        public Boolean updatePurchase(Cart cart)
        {
            return false;
        }

    }
}
