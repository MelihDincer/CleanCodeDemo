



//Merkez bankasının kodu gibi düşünelim

//İş bankasının kodu gibi düşünelim
public class IsBankServiceAdapter : IBankService
{
    public decimal ConvertRate(CurrencyRate currencyRate)
    {
        IsBankService centralBankService = new IsBankService();
        return centralBankService.ConvertRate(currencyRate);
    }
}