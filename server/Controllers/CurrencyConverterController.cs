using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CurrencyExchangeCalculator.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CurrencyExchangeCalculator.Controllers
{
   
    [Route("api/currency-exchange-calculator")]
    public class CurrencyConverterController : Controller
    {

        //private readonly ILogger<CurrencyConverterResponse> _logger;

        //public CurrencyConverterController(ILogger<CurrencyConverterResponse> logger) {
        //{
        //        _logger = logger;
        // } 

        // TEST-1.1 [SUCCESS]:http://localhost:54128/api/currency-exchange-calculator/amount/20/baseCurrency/usd/targetCurrency/eur
        // TEST-1.2 [SUCCESS]: http://localhost:54128/api/currency-exchange-calculator?amount=20&baseCurrency=eur&targetCurrency=usd
        // TEST-2 [FAIL]: http://localhost:54128/api/currency-exchange-calculator?amount=20&baseCurrency=eur&targetCurrency=BAD_TARGET

        [HttpGet()] // to accept query string format params
        [HttpGet("amount/{amount}/baseCurrency/{baseCurrency}/targetCurrency/{targetCurrency}")]
        [Produces("application/json")]
        public IActionResult Get(
            double amount,
            String baseCurrency,
            String targetCurrency)
        {

            var errors = CurrencyValidator.ValidateInput(baseCurrency, targetCurrency);
            if (errors.Count() == 0)
            {
                CurrencyManager converter = new CurrencyManager();
                CurrencyConverterResponse res = new CurrencyConverterResponse();
                res.conversion = converter.Convert(amount, baseCurrency, targetCurrency);

                return Ok(res);
            }
            else
            {
                return BadRequest(new { errors }); 
            }
                      
        }

 
     
    }
}
