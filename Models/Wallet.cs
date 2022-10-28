namespace Jala_university_Aula13;

public class WalletService : IWallet
{
  
    public int Id { get; set; }
    public const string WalletCurrency = "BRL";
    public decimal Balance { get;  set; }
    
    public Tuple<string, decimal> ExchangeMoney(string outgoingCurrency, decimal amount)
    {
        var currencies = new Currencies();
        CustomExcepctions(outgoingCurrency, amount);

        var total = (amount * currencies.getCurrency(outgoingCurrency)) - 0.01M;
        
        return new Tuple<string, decimal>(outgoingCurrency, total);
    }
    
    public void AddToBalance(decimal amount)
    {
        if (amount <= 0)
            throw new InvalidOperationException("Amount its below expected");

        Balance += amount;

    }

    public decimal GetBalance()
    {
        return Balance;
    }

    public void CustomExcepctions(string outgoingCurrency, decimal amount)
    { 
      
        if (amount < 50)
        {
            throw new InvalidOperationException("amount below expected");
        }

        if (amount > Balance)
        {
            throw new ArgumentException();
        }
    }


  }