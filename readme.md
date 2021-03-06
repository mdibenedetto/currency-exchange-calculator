# Description

This is simple currency exchange calculator. The calculator is composed by 2 main layers, a server side applicatin built using ASP.NET Core and a client built usind ReactJS.

Details:

1. The API infinite number of defined currencies and their exchange rates. The values are defined in the JSON file.

1. You can consume the API either with browser or with the React application
1. Allow user to enter the amount to exchange
1. Display the result.

# NB: This project was built with:

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

## Client structure folder

> ![alt](/docs/images/client-structure-folder.png)

## Server structure folder

> ![alt](/docs/images/server-structure-folder.png)

# Test application

## Test Server ASP.NET WebApi

- go to the folder `server`
- start **Visual Studio project**
- run the project
- in your browser, go to the url `http://localhost:54128`

A default page `index.html` is shown to help testing the WEB API

> ![alt](/docs/images/web-api-test-browser-index.png)

The page shows links to test 3 use cases:

- One link to test the WEB API using slash separated params
- One link to test the WEB API using url query params
- One link to test the WEB API using a bad formatted request

## Sample response

- Slash separated params - 20eur to usd:

  [http://localhost:54128/api/currency-exchange-calculator?amount=20&baseCurrency=eur&targetCurrency=usd](http://localhost:54128/api/currency-exchange-calculator?amount=20&baseCurrency=eur&targetCurrency=usd)

> ![alt](/docs/images/response-browser-query-param.png)

- Url query params - 20usd to eur:

[http://localhost:54128/api/currency-exchange-calculator/amount/20/baseCurrency/usd/](http://localhost:54128/api/currency-exchange-calculator/amount/20/baseCurrency/usd/)

> ![alt](/docs/images/response-browser-slash-param.png)

- Bad formatted request - FAIL REQUEST

[http://localhost:54128/api/currency-exchange-calculator?amount=20&baseCurrency=eur&targetCurrency=BAD_TARGET](http://localhost:54128/api/currency-exchange-calculator?amount=20&baseCurrency=eur&targetCurrency=BAD_TARGET)

> ![alt](/docs/images/response-browser-fail.png)

## Test Client React App

- go to the folder `client`
- use an Ide of your choice or just open the folder with your `terminal` app
- first time you need to install the project dependencies, to do that run the command `npm i`
- next step require to start the client app by using the command `npm star`
- the command will open the broweset so that you can test the app to the url `http://localhost:3000/`

The react app display the index.html

> ![alt](/docs/images/react-client-before.png)

From this page you can select the base currency, the amount to convert and the target currecy to use as reference for the desired conversion.

## Sample response

### Sample - 1

Lets say we choose:

- Base currency = eur
- Amount - 10
- Target currency - usd

The clien should show a response as shown below

> ![alt](/docs/images/react-client-after.png)

### Sample - 2

Lets say that for any reason the server web api is not working or simply we forgot to run the server.

The clien should show an alert message as shown below

> ![alt](/docs/images/react-client-fail-server.png)

### Sample - 3

#### Smart device view

> ![alt](/docs/images/smart-device-view.png)

# TODO

## Functionalities

- Add a server side proxy to call a real API which provide currency rate in real time
- Add a functional to invert BASE CURRENCY to TARGET CURRENCY and vice-versa

## Testing

- Add unit testing both clien and server side
- Add BDD testing both clien and server side

## JSON API WEBSITE REFERENCE

### JSON rate

- http://www.floatrates.com/json-feeds.html
- http://www.floatrates.com/daily/eur.json
- http://www.floatrates.com/daily/usd.json
- http://www.floatrates.com/daily/gbp.json
