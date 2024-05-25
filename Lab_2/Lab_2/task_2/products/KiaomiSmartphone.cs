namespace Lab_2.task_2.products;

public class KiaomiSmartphone(string model, string producer) 
    : IProductSmartphone
{
    public string Model { get; set; } = model;
    public string Producer { get; set; } = producer;
    
    public void Info()
    {
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Producer: {Producer}");
    }
}