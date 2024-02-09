using CleanCodeDemo.Business.Abstract;
using CleanCodeDemo.Entities.Concrete;
class ProductManager : BaseProcedureManager, IProductService
{
    private IBankService _bankService;

    public ProductManager(IBankService bankService)
    {
        _bankService = bankService;
    }

    public override void Sell(Product product, Student student)
    {
        decimal price = product.Price;
        price -= product.Price * 0.1M;
        price = _bankService.ConvertRate(new CurrencyRate { Currency = 1, Price = price });
        Console.WriteLine(price);
    }
    public override void Sell(Product product, Officer officer)
    {
        decimal price = product.Price;
        price -= product.Price * 0.2M;
        price = _bankService.ConvertRate(new CurrencyRate { Currency = 1, Price = price });
        Console.WriteLine(price);
    }
}