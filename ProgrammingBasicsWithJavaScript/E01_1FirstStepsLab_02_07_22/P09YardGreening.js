function yardGreening(input) {
    let pricePerMeter = 7.61;
    let metresForGreening = Number(input[0]);
    let allCost = pricePerMeter * metresForGreening;
    let priceLess = allCost * 0.18;
    allCost = allCost - priceLess;
    console.log(`The final price is: ${allCost} lv.`);
    console.log(`The discount is: ${priceLess} lv.`);
}

yardGreening(["150"])