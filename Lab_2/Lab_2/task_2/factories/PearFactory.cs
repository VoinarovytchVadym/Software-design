using Lab_2.task_2.products;

namespace Lab_2.task_2.factories;

public class PearFactory : IFactory
{
    private const string Producer = "Pear";
    public IProductLaptop CreateProductLaptop(string model)
    {
        return new PearLaptop(model, Producer);
    }

    public IProductSmartphone CreateProductSmartphone(string model)
    {
        return new PearSmartphone(model, Producer);
    }
}