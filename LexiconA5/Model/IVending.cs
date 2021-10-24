
using System;
using System.Collections.Generic;
using System.Text;
using LexiconA5.Products;

namespace LexiconA5.Model
{
    public interface IVending
    {
        string Purchase(Product prod);
        string ShowAll();
        void InsertMoney(int value);
        string EndTransaction();

    }
}
