using Microsoft.AspNetCore.Mvc;
using Middleware_Services.Services;

namespace Middleware_Services.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        //public WeatherForecastController(IMessagingService messageService)
        //{
        //    _messageService = messageService ?? throw new ArgumentException(nameof(messageService));
        //}

        //private readonly IMessagingService _messageService;

        //[HttpPost]
        //public ActionResult SendMessage()
        //{
        //    _messageService.SendMessage("Hello!");
        //    return Ok();
        //}



        public WeatherForecastController(BankWithdrawalService withdrawal)
        {
            _bankWithdrawalService = withdrawal ?? throw new ArgumentException(nameof(withdrawal));
        }
        private readonly BankWithdrawalService _bankWithdrawalService;

        [HttpPost]
        public ActionResult Withdraw()
        {
            _bankWithdrawalService.Withdraw(7000, 8000);
            return Ok();
        }
    }
}