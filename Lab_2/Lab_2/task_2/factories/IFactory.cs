using Lab_2.task_2.products;

namespace Lab_2.task_2.factories;

interface IFactory
{
    public IProductLaptop CreateProductLaptop(string model);
    public IProductSmartphone CreateProductSmartphone(string model);
}