function petShop(input) {
    let priceDogFood = 2.50;
    let priceCatFood = 4;
    let numberOfDogFoods = Number(input[0]);
    let numberOfCatFoods = Number(input[1]);
    let costForDogFood = priceDogFood * numberOfDogFoods;
    let costForCatFood = priceCatFood * numberOfCatFoods;
    let allCosts = costForDogFood + costForCatFood;
    console.log(`${allCosts} lv.`);
}

petShop(["5", "4"]);