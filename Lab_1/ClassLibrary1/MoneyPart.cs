using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

    public class MoneyPart
    {
        private int amount;

        public MoneyPart(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Значення не можу бути від'ємним");
            }
            this.amount = amount;
        }

        public int Amount 
        { 
            get 
            { 
                return amount; 
            }
            set 
            { 
                if (value < 0) 
                {
                    throw new ArgumentException("Значення не можу бути від'ємним");
                }
                amount = value;
            }
        }
    }
}
