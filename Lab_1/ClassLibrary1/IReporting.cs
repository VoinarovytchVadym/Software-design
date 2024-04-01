using System;

namespace ClassLibrary
{
    interface IReporting
    {
        void Print();
    }

    public class RevenueInvoice : IReporting
    {
        private Warehouse[] products;
        public Warehouse[] Products
        {
            get { return products; }
            set
            {
                if (value == null) throw new ArgumentException("Не може прийняти пустий об'єкт");
                products = value;
            }
        }

        public void Print()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{"|Id",-5}");
            Console.Write($"{"|Назва",-30}");
            Console.Write($"{"|Кількість",-15}");
            Console.Write($"{"|Од.",-10}");
            Console.Write($"{"|Ціна",-10}");
            Console.Write($"{"|Сумі",-10}");
            Console.WriteLine($"{"|Дата постачання",-22}|");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < Products.Length; i++)
            {
                Console.Write($"{"|" + (i + 1),-5}");
                Console.Write($"{"|" + Products[i].Product.Name,-30}");
                Console.Write($"{$"|{Products[i].Quantity:F2}",-15}");
                Console.Write($"{"|" + Products[i].Unit,-10}");
                Console.Write($"{"|" + Products[i].Product.Price.Print(),-10}");
                Console.Write($"{$"|{double.Parse(Products[i].Product.Price.Print()) * Products[i].Quantity:F2}",-10}");

                Console.WriteLine($"{"|" + Products[i].DeliveryDate,-22}|");
            }
        }

        public RevenueInvoice(Warehouse[] warehouses)
        {
            Products = warehouses;
        }
    }

    public class SalesInvoice : IReporting
    {
        private Warehouse[] products;
        public Warehouse[] Products
        {
            get { return products; }
            set
            {
                if (value == null) throw new ArgumentException("Не може прийняти пустий об'єкт");
                products = value;
            }
        }

        private string post;
        public string Post
        {
            get { return post; }
            set
            {
                if (value == string.Empty) throw new ArgumentException("Не може прийняти пустий рядок");
                post = value;
            }
        }

        private string costumer;
        public string Costumer
        {
            get { return costumer; }
            set
            {
                if (value == string.Empty) throw new ArgumentException("Не може прийняти пустий рядок");
                costumer = value;
            }
        }

        private string contract;
        public string Contract
        {
            get { return contract; }
            set
            {
                if (value == string.Empty) throw new ArgumentException("Не може прийняти пустий рядок");
                contract = value;
            }
        }

        public void Print()
        {
            Console.Clear();
            Console.WriteLine($"Постачальник: {Post}");

            Console.WriteLine($"Покупець: {Costumer}");

            Console.WriteLine($"Договір: {Contract}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{"|Id",-5}");
            Console.Write($"{"|Назва",-30}");
            Console.Write($"{"|Кількість",-15}");
            Console.Write($"{"|Од.",-10}");
            Console.Write($"{"|Ціна без ПДВ",-15}");
            Console.WriteLine($"{"|Сума без ПДВ",-15}|");
            Console.ForegroundColor = ConsoleColor.White;
            double result_sum = 0;
            for (int i = 0; i < Products.Length; i++)
            {
                Console.Write($"{"|" + (i + 1),-5}");
                Console.Write($"{"|" + Products[i].Product.Name,-30}");
                Console.Write($"{$"|{Products[i].Quantity:F2}",-15}");
                Console.Write($"{"|" + Products[i].Unit,-10}");
                Console.Write($"{"|" + Products[i].Product.Price.Print(),-15}");
                Console.WriteLine($"{$"|{double.Parse(Products[i].Product.Price.Print()) * Products[i].Quantity:F2}",-15}|");
                result_sum += double.Parse(Products[i].Product.Price.Print()) * Products[i].Quantity;
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Всього найменувань: {Products.Length}");
            Console.WriteLine($"Всього: {result_sum:F2}");
            Console.WriteLine($"Всього з ПДВ: {result_sum+(result_sum/100*20)}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public SalesInvoice(Warehouse[] warehouse, string post, string costumer, string contract)
        {
            Products = warehouse;
            Post = post;
            Costumer = costumer;
            Contract = contract;
        }
    }
    public class InventoryReport : IReporting
    {
        private Warehouse[] products;

        public Warehouse[] Products
        {
            get { return products; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Не може прийняти пустий об'єкт");
                products = value;
            }
        }

        public void Print()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Звіт по інвентаризації (залишки на складі)");
            Console.WriteLine($"{"|Id",-5}{"|Назва",-30}{"|Кількість",-15}{"|Од.",-10}{"|Ціна",-10}{"|Дата постачання",-22}|");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < Products.Length; i++)
            {
                Console.Write($"{"|" + (i + 1),-5}");
                Console.Write($"{"|" + Products[i].Product.Name,-30}");
                Console.Write($"{$"|{Products[i].Quantity:F2}",-15}");
                Console.Write($"{"|" + Products[i].Unit,-10}");
                Console.Write($"{"|" + Products[i].Product.Price.Print(),-10}");
                Console.WriteLine($"{"|" + Products[i].DeliveryDate,-22}|");
            }
        }

        public InventoryReport(Warehouse[] warehouses)
        {
            Products = warehouses;
        }
    }

}
