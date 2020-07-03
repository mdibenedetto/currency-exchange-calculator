using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CurrencyExchangeCalculator.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CurrencyExchangeCalculator.Controllers
{
    [Route("api/currency-exchange-calculator")]
    public class CurrencyConverterController : Controller
    {           
        [HttpGet]      
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
