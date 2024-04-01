using ClassLibrary;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Warehouse[] warehouses = new Warehouse[4];
        Product product = new Product("Product-1", new USD(12, 50));
        product.Discount(new USD(1, 50));
        warehouses[0]= new Warehouse(product, 1000, "шт.", DateTime.Now);
        warehouses[1]= new Warehouse(new Product("Product-2", new USD(121, 0)), 5, "кг.", DateTime.Now);
        warehouses[2]= new Warehouse(new Product("Product-3", new USD(1782, 20)), 3, "шт.", DateTime.Now);
        warehouses[3]= new Warehouse(new Product("Product-4", new USD(1, 50)), 100, "л.", DateTime.Now);
        RevenueInvoice revenueInvoice = new RevenueInvoice(warehouses);
        SalesInvoice salesInvoice = new SalesInvoice(warehouses, "Post", "Costumer", "Contract");
        InventoryReport inventoryReport = new InventoryReport(warehouses);
        
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("1)Формування прибуткової накладної");
            Console.WriteLine("2)Видаткова накладна");
            Console.WriteLine("3)Залишки на складі");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Виберіть:");
            Console.ForegroundColor = ConsoleColor.White;
            switch (Console.ReadLine())
            {
                case "1":
                    revenueInvoice.Print();
                    break;
                case "2":
                    salesInvoice.Print();
                    break;
                case "3":
                    inventoryReport.Print();
                    break;
            }
        }
        
    }
}