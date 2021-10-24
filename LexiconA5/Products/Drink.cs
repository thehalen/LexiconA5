using System;
using System.Collections.Generic;
using System.Text;

namespace LexiconA5.Products
{
    public class Drink : Product
    {
        public Drink(int price, string name, string description, string use) : base(price, name, description, use)
        {
        }
    }
}
