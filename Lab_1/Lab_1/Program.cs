using ClassLibrary;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Warehouse[] warehouses = new Warehouse[4];
        Warehouse warehouse1 = new Warehouse(new Product("Product-1", new USD(12, 50)), 1000, "шт.", DateTime.Now);
        Warehouse warehouse2 = new Warehouse(new Product("Product-2", new USD(121, 0)), 5, "кг.", DateTime.Now);
        Warehouse warehouse3 = new Warehouse(new Product("Product-3", new USD(1782, 20)), 3, "шт.", DateTime.Now);
        Warehouse warehouse4 = new Warehouse(new Product("Product-4", new USD(1, 50)), 100, "л.", DateTime.Now);
        warehouses[0]= warehouse1;
        warehouses[1]= warehouse2;
        warehouses[2]= warehouse3;
        warehouses[3]= warehouse4;
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