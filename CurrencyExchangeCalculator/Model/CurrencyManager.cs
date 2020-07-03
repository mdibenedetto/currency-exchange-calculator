using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace CurrencyExchangeCalculator.Model
{
    public class CurrencyManager
    {
        public List<String> inputCurrencyList
            = new List<String>
        {
             "eur", "usd", "gbp",
             "aud", "cad", "jpy",
             "chf", "cny", "hkd",
             "twd"
        };

        public List<String> currencyList 
             = new List<String>
             {
                "eur", "usd", "jpy", "bgn", "czk", "dkk", "gbp", "huf", "ltl", "lvl"
            , "pln", "ron", "sek", "chf", "nok", "hrk", "rub", "try", "aud", "brl", "cad", "cny", "hkd", "idr", "ils"
            , "inr", "krw", "mxn", "myr", "nzd", "php", "sgd", "zar"
             };

        public List<string> ValidateInput(String baseCurrency, String targetCurrency)
        {
            List<string> errors = new List<string>();

            if (inputCurrencyList.Contains(baseCurrency) == false)
            {
                errors.Add($"The input baseCurrency \"{baseCurrency}\" is not valid");
            }

            if (currencyList.Contains(targetCurrency) == false)
            {
                errors.Add($"The input target currency \"{targetCurrency}\" is not valid");
            }

            return errors;
        }

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