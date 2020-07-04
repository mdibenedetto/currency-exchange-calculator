export async function calculateExchange(
    amount: number,
    baseCurrency: string,
    targetCurrency: string) {

    document.body.setAttribute("data-loading", "true");

    const URL = "/api/currency-exchange-calculator";
    const params =
        `?amount=${amount}` +
        `&baseCurrency=${baseCurrency}` +
        `&targetCurrency=${targetCurrency}`;

    try {
        const data = await fetch(URL + params).then((res) => res.json());
        if (data.errors && data.errors.length > 0) {
            alert(
                "The service 'Exchange Calculator' has recieved a bad input." +
                "\nPlease recheck your inputs"
            );
        } else {
            return data.conversion.toFixed(2);
        }
    } catch (ex) {
        alert(
            "The service 'Exchange Calculator' is unavailable right." +
            "\nPlase try later."
        );
        console.log(ex);
    } finally {
        document.body.removeAttribute("data-loading");
    }
}