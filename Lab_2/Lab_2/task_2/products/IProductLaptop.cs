namespace Lab_2.task_2.products;

public interface IProductLaptop
{
    public string Model { get; set; }
    public string Producer { get; set; }
    
    public void Info();
}