namespace ClassLibrary
{
    public class Warehouse
    {
        private Product product;
        public Product Product
        {
            get { return product; }
            set { product = value; }
        }

        private double quantity;
        public double Quantity
        {
            get { return quantity; }
            set 
            {
                if(quantity < 0) throw new ArgumentException("Кількість не може бути менше нуля"); 
                quantity = value;
            }
        }
        private string unit;
        public string Unit
        {
            get { return unit; }
            set
            {
                if (unit.Length == 0) throw new ArgumentException("Не можна задати пусте значення");
                unit = value;
            }
        }
        private DateTime deliveryDate;
        public DateTime DeliveryDate
        {
            get { return deliveryDate; }
            set
            {
                if (deliveryDate > DateTime.Now) throw new ArgumentException("Вказанна дата є не коректною");
                deliveryDate = value;
            }
        }
        public Warehouse(Product product, double quantity, string unit, DateTime deliveryDate)
        {
            if(quantity<0 || unit== string.Empty || deliveryDate > DateTime.Now) throw new ArgumentException("Переданні хибні значення");
            this.product = product;
            this.quantity = quantity;
            this.unit = unit;
            this.deliveryDate = deliveryDate;
        }
    }
}
