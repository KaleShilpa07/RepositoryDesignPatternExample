using DebitCreditAmtExample.Infrastructure.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging; // Add this namespace

namespace DebitCreditAmtExample.Controllers
{
    
    public class TransactionController : ControllerBase
    {
        private readonly Itransaction _itransaction;
        private readonly ILogger<TransactionController> _logger; // Inject ILogger

        public TransactionController(Itransaction itransaction, ILogger<TransactionController> logger)
        {
            _itransaction = itransaction;
            _logger = logger;
        }

        [HttpPost("Deposit")]
        public IActionResult Deposit(decimal amount)
        {
            _itransaction.Deposit(amount);
            _logger.LogInformation("Deposit action called. Amount: {amount}, Balance: {balance}", amount, _itransaction.Balance); // Log information
            return Ok(new { balance = _itransaction.Balance });
        }

        [HttpPost("Withdraw")]
        public IActionResult Withdraw(decimal amount)
        {
            _itransaction.WithDraw(amount);
            _logger.LogInformation("Withdraw action called. Amount: {amount}, Balance: {balance}", amount, _itransaction.Balance); // Log information
            return Ok(new { balance = _itransaction.Balance });
        }
    }
}
