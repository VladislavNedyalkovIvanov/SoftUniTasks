function vegetableMarket(input) {
    let priceVegetables = (input[0]);
    let priceFruits = (input[1]);
    let kilogramsVegetables = (input[2]);
    let kilogramsFruits = (input[3]);
    let courseOfEuro = 1.94;

    let allCost = (priceVegetables * kilogramsVegetables) + (priceFruits * kilogramsFruits);
    let allCostInEuro = allCost / courseOfEuro;
    console.log(allCostInEuro.toFixed(2));
    
}

vegetableMarket(["1.5", "2.5", "10", "10"]);