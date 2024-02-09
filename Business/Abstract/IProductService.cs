using CleanCodeDemo.Entities.Concrete;

public interface IProductService
{
    void Sell(Product product, Officer officer);
    void Sell(Product product, Student student);
}
