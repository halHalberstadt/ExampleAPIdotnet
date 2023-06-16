namespace ExampleAPIdotnet
{
    public class Card
    {
        public long Id { get; set; }
        public string NameOnCard { get; set; }
        public long CardNumber { get; set; }
        public uint CardExpiration { get; set; } // in the form 0,dd0,mm0y,yyy 
        public ushort Zipcode { get; set; }

        public Card()
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
