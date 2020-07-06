# NB: This project was built in the with:

- MAC OS MACHINE
- Visual Studio Community Edition
- ASPNET CORE 3.1
- VS CODE fo MacOS
- Create-React-App CLI

# Basic Requirements

## React-App

- NodeJS
- npm

## ASPNET

- ASP.NET CORE 3.1

# Test application

## Test Server ASP.NET WebApi

- start Visual Studio project
- run project
- go to the browswer `http://localhost:54128`

A default page index.html is shown to help to test the WEB API

![alt](/docs/images/web-api-test-browser-index.png)

The page allow to test 3 use cases:

- One link test the WEB API using slash separated params
- One link test the WEB API using url query params
- One link the WEB API using a bad formatted request

## Sample response

- [SUCCESS REQUEST 1 - 20eur to usd: http://localhost:54128/api/currency-exchange-calculator?amount=20&baseCurrency=eur&targetCurrency=usd](http://localhost:54128/api/currency-exchange-calculator?amount=20&baseCurrency=eur&targetCurrency=usd)

![alt](/docs/images/response-browser-query-param.png)

- [SUCCESS REQUEST 2 - 20usd to eur: http://localhost:54128/api/currency-exchange-calculator/amount/20/baseCurrency/usd/](http://localhost:54128/api/currency-exchange-calculator/amount/20/baseCurrency/usd/)

![alt](/docs/images/response-browser-slash-param.png)

- [FAIL REQUEST - http://localhost:54128/api/currency-exchange-calculator?amount=20&baseCurrency=eur&targetCurrency=BAD_TARGET](http://localhost:54128/api/currency-exchange-calculator?amount=20&baseCurrency=eur&targetCurrency=BAD_TARGET)

![alt](/docs/images/response-browser-fail.png)

## Test Client React App
