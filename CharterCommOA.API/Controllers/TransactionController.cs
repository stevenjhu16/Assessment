using Microsoft.AspNetCore.Mvc;
using AppCore.Contracts.Services;

namespace CharterCommOA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;
        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet]
        [Route("{customerId:int}")]
        public ActionResult<decimal> GetQuarterlyPoints(int customerId)
        {
            var points = _transactionService.GetQuarterlyPoints(customerId);
            return Ok(points);
        }

        [HttpGet]
        [Route("{customerId:int}/{targetMonth:int}")]
        public ActionResult<decimal> GetMonthlyRewards(int targetMonth, int customerId)
        {
            var points = _transactionService.GetMonthlyPoints(targetMonth, customerId);
            return Ok(points);
        }

        
    }
}
