namespace Lab_2.task_4;

public interface IVirus<T> 
    where T : new()
{
    void PerformCopyTo(T obj);

    public T PerformCopy()
    {
        T t = new();
        PerformCopyTo(t);
        return t;
    }

}