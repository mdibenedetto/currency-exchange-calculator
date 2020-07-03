using System;
using System.IO;
using Newtonsoft.Json;

namespace CurrencyExchangeCalculator.Model
{
    public class CurrencyManager
    {
        public string[] currencyList = {
                "eur", "usd", "jpy", "bgn", "czk", "dkk", "gbp", "huf", "ltl", "lvl"
            , "pln", "ron", "sek", "chf", "nok", "hrk", "rub", "try", "aud", "brl", "cad", "cny", "hkd", "idr", "ils"
            , "inr", "krw", "mxn", "myr", "nzd", "php", "sgd", "zar"};
 

        public decimal Convert (
            decimal amount,
            String baseCurrency,
            String targetCurrency)
        {
            // If currency's are empty abort
            if (baseCurrency == null || targetCurrency == null)
                return 0;

            
            if (baseCurrency.ToLower() == targetCurrency.ToLower())
                return amount;


            

            decimal res = 42;


            return res;
        }

        public object Get()
        {
            var folderDetails = Path.Combine(
                Directory.GetCurrentDirectory(),
                $"wwwroot/{"Data/rates/aud.json"}");

            string allText = File.ReadAllText(folderDetails);

            object jsonObject = JsonConvert.DeserializeObject(allText);
            return jsonObject;
        }
    }
}
