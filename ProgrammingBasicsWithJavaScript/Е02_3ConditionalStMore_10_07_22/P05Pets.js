function pets(inbox) {
    let daysLeft = Number(inbox[0]);
    let foodLeft = Number(inbox[1]);
    let dailyFoodForDog = Number(inbox[2]);
    let dailyFoodForCat = Number(inbox[3]);
    let dailyFoodForTurtle = Number(inbox[4]);

    dailyFoodForTurtle = dailyFoodForTurtle / 1000;
    let neededFood = null;
    neededFood = (dailyFoodForDog + dailyFoodForCat + dailyFoodForTurtle) * daysLeft;

    if (foodLeft >= neededFood) {
        foodLeft = foodLeft - neededFood;
        console.log(`${Math.floor(foodLeft)} kilos of food left.`);
    } else {
        let moreFoodNeeds = neededFood - foodLeft;
        console.log(`${Math.ceil(moreFoodNeeds)} more kilos of food are needed.`)
    }
}

pets(["5", "10", "2.1", "0.8", "321"])