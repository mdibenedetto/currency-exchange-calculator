import React from 'react';

import {
  Loader,
  CurrencySelector,
  ButtonConverter,
} from './components';

import baseCurrencyList from './data/base-currency-list.json';
import targetCurrencyList from './data/target-currency-list.json';
import { calculateExchange } from './model/Calculator';


function App() {



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
          />
        </section>

        <section className="row">
          <CurrencySelector
            id="ddTargetCurrency"
            currencyList={targetCurrencyList}
            label="Currency I want"
            disabled
          />
        </section>

        <section className="row">
          <ButtonConverter onClick={() => calculateExchange(1.2, "", "")} />
        </section>

      </main>
    </>
  );
}

export default App;
