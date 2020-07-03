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
    

        // GET: api/values
        [HttpGet]
        //[Consumes("application/json")]
        [Produces("application/json")]
        public CurrencyConverterResponse Get(
            decimal amount,
            String baseCurrency,
            String targetCurrency)
        {
            CurrencyManager converter = new CurrencyManager();

            if(converter.ValidateInput(baseCurrency))
            {
                CurrencyConverterResponse res = new CurrencyConverterResponse();
                res.conversion = converter.Convert(amount, baseCurrency, targetCurrency);
                return Ok(res);

            }
            else
            {

            }


           
        }


        [HttpGet("test-1")]
        public Object Get()
        {
            CurrencyConverterResponse res = new CurrencyConverterResponse();
 
            res.conversion = 33;
            return new {
                conversion = 33
            };
        }

        [HttpGet("test-2")]
        public CurrencyConverterResponse Get2()
        {
            CurrencyConverterResponse res = new CurrencyConverterResponse();

            res.conversion = 33;

            return res;
        }
        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value:  " + id;
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
