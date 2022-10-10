function tradeCommissions(inbox) {
    let nameOfCity = (inbox[0]);
    let numberOfSales = Number(inbox[1]);
    let result = "error";
    if (numberOfSales >= 0 && numberOfSales <= 500) {
        if (nameOfCity === "Sofia") {
            result = 5;
        } else if (nameOfCity === "Varna") {
            result = 4.5;
        } else if (nameOfCity === "Plovdiv") {
            result = 5.5;
        }
    } else if (numberOfSales > 500 && numberOfSales <= 1000) {
        if (nameOfCity === "Sofia") {
            result = 7;
        } else if (nameOfCity === "Varna") {
            result = 7.5;
        } else if (nameOfCity === "Plovdiv") {
            result = 8;
        }
    } else if (numberOfSales > 1000 && numberOfSales <= 10000) {
        if (nameOfCity === "Sofia") {
            result = 8;
        } else if (nameOfCity === "Varna") {
            result = 10;
        } else if (nameOfCity === "Plovdiv") {
            result = 12;
        }
    } else if (numberOfSales > 10000) {
        if (nameOfCity === "Sofia") {
            result = 12;
        } else if (nameOfCity === "Varna") {
            result = 13;
        } else if (nameOfCity === "Plovdiv") {
            result = 14.5;
        }
    }
    if (result != "error") {
        let percent = result / 100;
        result = numberOfSales * percent;
        console.log(`${result.toFixed(2)}`)
    } else {
        console.log(result);
    }
}

tradeCommissions(["Kaspichan",
"-50"])



