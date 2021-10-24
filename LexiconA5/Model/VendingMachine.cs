using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LexiconA5.Products;

namespace LexiconA5
{
    public class VendingMachine : Model.IVending
    {
        private static readonly int[] denominations = {1000,500,200,100,50,20,10,5,2,1 }; // only in decreasing order
        private List<Product> stock = new List<Product>();
        private int deposit;

        public int GetDeposit { get => deposit; }

        /// <summary>
        /// How many products are in stock
        /// </summary>
        /// <returns>Int number of products</returns>
        public int NumberOfProducts()
        {
            return stock.Count;
        }
        /// <summary>
        /// Add a product to the stock
        /// </summary>
        /// <param name="p">And Product-based object</param>
        public void AddProduct(Product p)
        {
            stock.Add(p);
        }

        /// <summary>
        /// Purchases a product if enough money has been deposited.
        /// </summary>
        /// <param name="prod">Desired Product</param>
        /// <returns>Result string</returns>
        public string Purchase(Product prod)
        {
            if (deposit >= prod.Price && stock.Remove(prod)) //if enough money is deposited, try to remove the product from the stock
            {
                deposit -= prod.Price;
                return prod.Name + " bought for " + prod.Price + "kr, remaining deposit: " + deposit;
            }
            else
            {
                return "Sorry, couldn't buy " + prod.Name + ".";
            }
        }

        /// <summary>
        /// Displays all unique products in stock
        /// </summary>
        public string ShowAll()
        {
            var uniqueCategories = stock.
                                   Select(p => p).
                                   Distinct().ToList();
            StringBuilder str = new StringBuilder("Currently available products:" + Environment.NewLine);
            foreach (Product prod in uniqueCategories)
            { 
                str.Append(prod.Name + ": " + prod.Price + "kr." + Environment.NewLine);
            }
            return str.ToString();
        }
        
        /// <summary>
        /// Insert a coin or a bank note, if valid, gets added to the deposited sum
        /// </summary>
        /// <param name="value">Value of deposited money, needs to be a valid denomination</param>
        public void InsertMoney(int value)
        {
            if (denominations.Contains(value))
            {
                deposit += value;
            }
            else
            {
                Console.WriteLine("That isn't a legal denomination. Sorry.");
            }
        }
         
        /// <summary>
        /// Concludes the purchases
        /// </summary>
        /// <returns>String with change, per denomination</returns>
        public string EndTransaction()
        {
            return CreateChangeString(deposit);
        }


        /// <summary>
        /// String with change, per denomination
        /// </summary>
        /// <param name="sum">The sum of change to be returned</param>
        /// <returns></returns>
        public static string CreateChangeString(int sum)
        {
            StringBuilder str = new StringBuilder("Change ("+sum+"kr):" +Environment.NewLine);
            int num;
            foreach (int den in denominations)
            {
                num = (sum / den); //int division -> rounds towards 0
                sum -= (den * num); 
                str.Append(num + "x" + den + Environment.NewLine); //could have inline if num!=0 for brevity
            }
            return str.ToString();
        }


    }


}
