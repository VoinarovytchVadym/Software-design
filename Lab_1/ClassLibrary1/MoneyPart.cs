namespace ClassLibrary
{

    public class MoneyPart
    {
        private int amount;
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

        public MoneyPart(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Значення не можу бути від'ємним");
            }
            this.amount = amount;
        }

    }
}
