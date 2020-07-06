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

- go to the folder `server`
- start **Visual Studio project**
- run the project
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

- go to the folder `client`
- use an Ide of your choice or just open the folder with your `terminal` app
- first time you need to install the project dependencies, to do that run the command `npm i`
- next step require to start the client app by using the command `npm star`
- the command will open the broweset so that you can test the app to the url `http://localhost:3000/`

The react app display the index.html

![alt](/docs/images/react-client-before.png)

From this page you can select the base currency, the amount to convert and the target currecy to use as reference for the desired conversion.

## Sample response

### Sample - 1

Lets say we choose:

- Base currency = eur
- Amount - 10
- Target currency - usd

The clien should show a response as shown below

![alt](/docs/images/react-client-after.png)

### Sample - 2

Lets say that for any reason the server web api is not working or simply we forgot to run the server.

The clien should show an alert message as shown below

![alt](/docs/images/react-client-fail-server.png)
