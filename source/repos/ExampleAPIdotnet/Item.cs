﻿namespace ExampleAPIdotnet
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public long Id { get; set; }
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

    }
}