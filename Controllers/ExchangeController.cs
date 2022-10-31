using Microsoft.AspNetCore.Mvc;

namespace Jala_university_Aula13.Controllers;

[Route("api/[controller]/[action]")]
public class ExchangeController : Controller
{
    private readonly IExchange _exchange;
    private readonly IWallet _wallet;

    public ExchangeController(IExchange exchange, IWallet wallet)
    {
        _exchange = exchange;
        _wallet = wallet;
    }

    [HttpGet]
    public IActionResult GetAvailableMoney()
    {
        return Ok(_wallet.Balance);
    }

    [HttpPost]
    public ActionResult ExchangeMoney(string money, decimal amount)
    {
        var result = _exchange.ExchangeMoney(money, amount);
        return Ok(result);
    }

    [HttpPost]
    public IActionResult AddMoneyToWallet(decimal amount)
    {
        _wallet.AddToBalance(amount);
        return Ok("Amount add to the wallet");
    }

}