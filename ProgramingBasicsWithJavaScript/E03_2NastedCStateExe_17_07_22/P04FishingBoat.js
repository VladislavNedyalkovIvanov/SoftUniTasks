function fishingBoat(inbox) {
    let boudget = Number(inbox[0]);
    let season = (inbox[1]);
    let fishermans = parseInt(inbox[2]);
    let price = 0;
    if (season === "Spring") {
        price = 3000;
    } else if (season === "Summer" || season === "Autumn") {
        price = 4200;
    } else if (season === "Winter") {
        price = 2600;
    }
    if (fishermans <= 6) {
        price = price - (price * 0.10);
    } else if (fishermans > 7 && fishermans <= 11) {
        price = price - (price * 0.15);
    } else if (fishermans > 12) {
        price = price - (price * 0.25);
    }
    if (fishermans % 2 === 0 && season !== "Autumn") {
        price = price - (price * 0.05);
    }
    if (boudget >= price) {
        let moneyLeft = boudget - price;
        console.log(`Yes! You have ${moneyLeft.toFixed(2)} leva left.`)
    } else {
        let moneyNeeds = price - boudget;
        console.log(`Not enough money! You need ${moneyNeeds.toFixed(2)} leva.`)
    }
}

fishingBoat(["2000",
"Winter",
"13"])


