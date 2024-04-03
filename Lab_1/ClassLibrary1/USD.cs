namespace ClassLibrary
{
    public class USD
    {
        private MoneyPart dollars;
        private MoneyPart cents;


        public MoneyPart Dollars
        {
            get { return dollars; }
            set { dollars = value; }
        }
        public MoneyPart Cents
        {
            get { return cents; }
            set 
            {
                if (cents.Amount >= 100) throw new ArgumentException("Копійок не може бути більше 99");
                cents = value; 
            }
        }

        public USD(int dolars, int cents)
        {
            this.dollars = new MoneyPart(dolars);
            if (cents >= 100) throw new ArgumentException("Копійок не може бути більше 99");
            this.cents = new MoneyPart(cents);
        }

        public string Print()
        {
            return $"{dollars.Amount},{cents.Amount}";
        }
    }
}
