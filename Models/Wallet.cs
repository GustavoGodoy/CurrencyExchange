namespace Jala_university_Aula13;

public class Wallet : IWallet
{
  
    public int Id { get; set; }
    public const string WalletCurrency = "BRL";
    public decimal Balance { get;  private set; }
    
    public void AddToBalance(decimal amount)
    {
        if (amount <= 0)
            throw new InvalidOperationException("Amount its below expected");

        Balance += amount;

    }

  }