namespace Lab_2.task_2.products;

public class KiaomiLaptop(string model, string producer)
    : IProductLaptop
{
    public string Model { get; set; } = model;
    public string Producer { get; set; } = producer;
    
    public void Info()
    {
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Producer: {Producer}");
    }
}