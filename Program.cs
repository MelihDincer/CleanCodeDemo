using CleanCodeDemo.Entities.Concrete;

Customer customer1 = new Customer
{
    Id = 1,
    Name = "Melih"
};

IProductService productService = new ProductManager(new IsBankServiceAdapter());
productService.Sell(new Product { Id = 1, Name = "Laptop", Price = 1000 }, new Officer { Id = 1, Name = "Melih" });
productService.Sell(new Product { Id = 1, Name = "Laptop", Price = 5000 }, new Student { Id = 2, Name = "Mehmet" });

public class FakeBankService : IBankService
{
    public decimal ConvertRate(CurrencyRate currencyRate)
    {
        return currencyRate.Price / 30.60M;
    }
}

//Merkez bankasının kodu gibi düşünelim
class CentralBankService
{
    public decimal ConvertRate(CurrencyRate currencyRate)
    {
        return currencyRate.Price / 30.58M;
    }
}

//İş bankasının kodu gibi düşünelim
class IsBankService
{
    public decimal ConvertRate(CurrencyRate currencyRate)
    {
        return currencyRate.Price / 30.55M;
    }
}
