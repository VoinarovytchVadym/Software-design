using System.Diagnostics.CodeAnalysis;
using Lab_2.task_2.products;

namespace Lab_2.task_2.factories;

public class KiaomiFactory : IFactory
{
    private const string Producer = "Kiaomi";

    public IProductLaptop CreateProductLaptop(string model)
    {
        return new KiaomiLaptop(model, Producer);
    }

    public IProductSmartphone CreateProductSmartphone(string model)
    {
        return new KiaomiSmartphone(model, Producer);
    }
}