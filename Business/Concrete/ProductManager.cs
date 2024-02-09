

class ProductManager : IProductService
{
    private IBankService _bankService;

    public ProductManager(IBankService bankService)
    {
        _bankService = bankService;
    }

    public void Sell(Product product, Customer customer)
    {
        //Burası refactor edilecek.

        decimal price = product.Price;
        if (customer.IsStudent)
        {
            price -= product.Price * 0.1M;
        }
        if (customer.IsOfficer)
        {
            price -= product.Price * 0.2M;
        }
        price = _bankService.ConvertRate(new CurrencyRate { Currency = 1, Price = price });
        Console.WriteLine(price);
        Console.ReadLine();
    }
}
