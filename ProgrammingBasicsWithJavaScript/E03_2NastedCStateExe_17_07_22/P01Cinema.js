function cinema(inbox) {

    let pricePremiere = 12.00;
    let priceNormal = 7.50;
    let priceDiscount = 5.00;
    let typeOfMovie = (inbox[0]);
    let numberOfRows = Number(inbox[1]);
    let numberOfColumns = Number(inbox[2]);
    let price = null;

    switch(typeOfMovie) {
        case "Premiere": price = (numberOfRows * numberOfColumns) * pricePremiere; break;
        case "Normal": price = (numberOfRows * numberOfColumns) * priceNormal; break;
        case "Discount": price = (numberOfRows * numberOfColumns) * priceDiscount; break;
    }
    console.log(`${price.toFixed(2)} leva`)

}

cinema(["Discount",
"12",
"30"])

