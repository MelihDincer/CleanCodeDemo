
Customer customer1 = new Customer
{
    Id = 1,
    Name = "Engin",
    IsStudent = true,
    IsOfficer = false
};

IProductService productService = new ProductManager(new IsBankServiceAdapter());
productService.Sell(new Product { Id = 1, Name = "Laptop", Price = 1000 }, new Customer { Id = 1, Name = "Engin", IsStudent = true, IsOfficer = false });

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
