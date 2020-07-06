import React, { useState } from 'react';

import {
  Loader,
  CurrencySelector,
  ButtonConverter,
} from './components';

import baseCurrencyList from './data/base-currency-list.json';
import targetCurrencyList from './data/target-currency-list.json';
import { calculateExchange } from './model/Calculator';


function App() {

  const [currency, setCurrency] = useState({
    baseCurrency: "eur",
    amount: 1,
    targetCurrency: "usd",
    amountConverted: 0
  });

  function updateField(key: string, value: string | number) {
    setCurrency({
      ...currency,
      [key]: value
    });
  }

  async function convert() {
    const {
      amount, baseCurrency, targetCurrency
    } = currency;

    const amountConverted = await calculateExchange(amount, baseCurrency, targetCurrency);
    updateField('amountConverted', amountConverted);
  }

  return (
    <>
      <Loader />

      <main className="container">

        <header className="title-header">
          <h1>Currency Converter</h1>
        </header>

        <section className="row">
          <CurrencySelector
            id="ddBaseCurrency"
            currencyList={baseCurrencyList}
            label="Currency I have"
            defaultCurrencyValue={currency.baseCurrency}
            defaultAmountValue={1}
            onCurrencyChange={(value: string) => updateField("baseCurrency", value)}
            onAmountChange={(value: number) => updateField("amount", value)}
          />
        </section>

        <section className="row">
          <CurrencySelector
            id="ddTargetCurrency"
            currencyList={targetCurrencyList}
            label="Currency I want"
            defaultCurrencyValue={currency.targetCurrency}
            amountValue={currency.amountConverted}
            onCurrencyChange={(value: string) => updateField("targetCurrency", value)}
            disabled
          />
        </section>

        <section className="row">
          <ButtonConverter onClick={convert} />
        </section>

      </main>
    </>
  );
}

export default App;
