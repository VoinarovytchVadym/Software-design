using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Product
    {
        private string name;
        private USD price;
        public string Name 
        { 
            get { return name;}  
            set 
            {
                if (value.Length <= 0) throw new ArgumentException("Введенно пусте значення");
                name = value;
            } 
        }
        public USD Price
        {
            get { return price; }
            set { price = value; }
        }
        public void Discount(USD discount)
        {
            price.Dollars.Amount -= discount.Dollars.Amount;
            price.Cents.Amount -= discount.Cents.Amount;
        }

        public Product(string name, USD usd)
        {
            if (name.Length <= 0) throw new ArgumentException("Введенно пусте значення");
            this.name = name;
            this.price = usd;
        }
    }
}
