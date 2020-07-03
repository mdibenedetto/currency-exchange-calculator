using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using CurrencyExchangeCalculator.Model;

namespace CurrencyExchangeCalculator.Model
{
    public class CurrencyManager
    {            
        public double Convert(
            double amount,
            String baseCurrency,
            String targetCurrency)
        {

            if (baseCurrency == null || targetCurrency == null)
                return 0;


            if (baseCurrency.ToLower() == targetCurrency.ToLower())
                return amount;

            var cr = GetRatesByCurrency(baseCurrency, targetCurrency);
            var res = cr.rate * amount;

            return res;
        }

        
        private CurrencyRate GetRatesByCurrency(
            String baseCurrency,
            String targetCurrency)
        {
            var folderDetails = Path.Combine(
                Directory.GetCurrentDirectory(),
                $"wwwroot/{"Data/rates/" + baseCurrency + ".json"}");

            string allText = File.ReadAllText(folderDetails);
            var rates = JsonConvert
                    .DeserializeObject<Dictionary<string, CurrencyRate>>
                    (allText);

            CurrencyRate rate = rates[targetCurrency];
          
 
            return rate;
        }
    }
}