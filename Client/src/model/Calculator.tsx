export async function calculateExchange(
    amount: number,
    baseCurrency: string,
    targetCurrency: string): Promise<number> {

    document.body.setAttribute("data-loading", "true");
    // TODO:   URL SERVER TEST
    // const SERVER = `http://localhost:54128`;    
    // const URL = SERVER + "/api/currency-exchange-calculator";

    const URL = "/api/currency-exchange-calculator";
    const params =
        `?amount=${amount}` +
        `&baseCurrency=${baseCurrency}` +
        `&targetCurrency=${targetCurrency}`;

    try {
        const data = await fetch(URL + params).then((res) => res.json());

        // log
        console.log("SERVER RESPONSE");
        console.log(data);

        if (data.errors && data.errors.length > 0) {
            alert(
                "The service 'Exchange Calculator' has recieved a bad input." +
                "\nPlease recheck your inputs"
            );
        } else {
            return parseFloat(data.conversion.toFixed(2));
        }
    } catch (ex) {
        alert(
            "The service 'Exchange Calculator' is unavailable right." +
            "\nPlase try later."
        );
        console.error(ex);
    } finally {
        document.body.removeAttribute("data-loading");
    }

    return 0;
}