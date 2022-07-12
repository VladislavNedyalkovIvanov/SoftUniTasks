function toyShop(inbox) {
    let puzzlePrice = 2.60;
    let talkingDollPrice = 3;
    let teddyBearPrice = 4.10;
    let minionPrice = 8.20;
    let truckPrice = 2;

    let priceExcursion = Number(inbox[0]);
    let puzzlesNumber = Number(inbox[1]);
    let talkingDollNumber = Number(inbox[2]);
    let teddyBearNumber = Number(inbox[3]);
    let minionNumber = Number(inbox[4]);
    let truckNumber = Number(inbox[5]);

    let numberOfAllToys = puzzlesNumber + talkingDollNumber + teddyBearNumber + minionNumber + truckNumber;
    let allCost = (puzzlesNumber * puzzlePrice) + (talkingDollNumber * talkingDollPrice) + (teddyBearNumber * teddyBearPrice) + (minionNumber * minionPrice) + (truckNumber * truckPrice);
    
    if (numberOfAllToys >= 50) {
        allCost = allCost - (allCost * 0.25);
    }
    allCost = allCost - (allCost * 0.10);
    if (allCost >= priceExcursion) {
        let allLeft = allCost - priceExcursion;
        console.log(`Yes! ${allLeft.toFixed(2)} lv left.`);
    } else {
        let allNeed = priceExcursion - allCost;
        console.log(`Not enough money! ${allNeed.toFixed(2)} lv needed.`);
    }
}

toyShop(["320",
"8",
"2",
"5",
"5",
"1"])

