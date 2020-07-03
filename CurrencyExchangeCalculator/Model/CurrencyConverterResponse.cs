using System;
namespace CurrencyExchangeCalculator.Model
{ 
    public class CurrencyConverterResponse
    {
        public double conversion { get; set; }

        decimal amount;
        String baseCurrency;
        String targetCurrency;
    }
}
