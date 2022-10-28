using Microsoft.AspNetCore.Mvc;

namespace Jala_university_Aula13.Controllers;

[Route("api/[controller]/[action]")]
public class ExchangeController : Controller
{
    private readonly IWallet _walletService;

    public ExchangeController(IWallet walletService)
    {
        _walletService = walletService;
    }

    [HttpGet]
    public IActionResult GetAvailableMoney()
    {
        return Ok(_walletService.GetBalance());
    }

    [HttpPost]
    public ActionResult ExchangeMoney(string money, decimal amount)
    {
        var result = _walletService.ExchangeMoney(money, amount);
        return Ok(result);
    }

    [HttpPost]
    public IActionResult AddMoneyToWallet(decimal amount)
    {
        _walletService.AddToBalance(amount);
        return Ok("Valor foi adicionado a carteira");
    }

}