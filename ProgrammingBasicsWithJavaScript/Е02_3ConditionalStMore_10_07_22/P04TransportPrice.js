function transportPrice(inbox) {
    let n = Number(inbox[0]);
    let timeOfDay = (inbox[1]);
    let tariff = null;
    let price = null;
    if (n < 20) {
        price = 0.70;
        switch (timeOfDay) {
            case "day":
                tariff = 0.79;
                break;
            case "night":
                tariff = 0.90;
                break;
        }
    } else if (n >= 20 && n < 100){
        tariff = 0.09;
    } else {
        tariff = 0.06;
    }
    price += tariff * n;
    console.log(`${price.toFixed(2)}`);
}

transportPrice(["180", "night"])