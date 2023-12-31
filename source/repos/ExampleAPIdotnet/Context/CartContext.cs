﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;

namespace ExampleAPIdotnet.Context
{

    public class CartContext : DbContext
    {

        public CartContext(DbContextOptions<CartContext> options) : base(options) {
        }

    }

    public class CartContextFactory : IDesignTimeDbContextFactory<CartContext>
    {
        public CartContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CartContext>();
            optionsBuilder.UseSqlServer("Data Source=Cart.db");

            return new CartContext(optionsBuilder.Options);
        }
    }
}