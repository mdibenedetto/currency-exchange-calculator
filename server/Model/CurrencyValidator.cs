using System;
using System.Collections.Generic; 

namespace CurrencyExchangeCalculator.Model
{
    public static class CurrencyValidator
    {
        public static List<string> ValidateInput(String baseCurrency, String targetCurrency)
        {
            CurrencyList cList = new CurrencyList();

            List<string> errors = new List<string>();

            if (cList.BaseCurrencyList.Contains(baseCurrency) == false)
            {
                errors.Add($"The input baseCurrency \"{baseCurrency}\" is not valid");
            }

            if (cList.TargetCurrencyList.Contains(targetCurrency) == false)
            {
                errors.Add($"The input target currency \"{targetCurrency}\" is not valid");
            }

            return errors;
        }
    }
}
