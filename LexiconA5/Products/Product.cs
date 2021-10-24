using System;
using System.Collections.Generic;
using System.Text;

namespace LexiconA5.Products
{
    public abstract class Product
    {
        private readonly int price;
        private readonly string name, description, use;

        protected Product(int price, string name, string description, string use)
        {
            this.price = price;
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.description = description ?? throw new ArgumentNullException(nameof(description));
            this.use = use ?? throw new ArgumentNullException(nameof(use));
        }

        public string Name { get => name; }
        public int Price { get => price;}

        public string Examine()
        {
            return description;
        }

        public string Use()
        {
            return use;
        }
        public override bool Equals(object obj)
        {
            return ((Product)obj).description == description &&
                   ((Product)obj).price == price;
        }
        public override int GetHashCode()
        {
            return description.GetHashCode();
        }
    }
}
