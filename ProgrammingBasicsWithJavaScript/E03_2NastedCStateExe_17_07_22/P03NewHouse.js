function newHouse(inbox) {
    let typeOfFlowers = (inbox[0]);
    let numberOfFlowers = Number(inbox[1]);
    let boudget = Number(inbox[2]);

    let discount = 0;
    let addPrice = 0;
    let price = 0;
    if (typeOfFlowers === "Roses") {
        if (numberOfFlowers > 80) {
            discount = 0.10;
        }
        price = 5;
    } else if (typeOfFlowers === "Dahlias") {
        if (numberOfFlowers > 90) {
            discount = 0.15;
        }
        price = 3.80;
    } else if (typeOfFlowers === "Tulips") {
        if (numberOfFlowers > 80) {
            discount = 0.15;
        }
        price = 2.80;
    } else if (typeOfFlowers === "Narcissus") {
        if (numberOfFlowers < 120) {
            addPrice = 0.15;
        }
        price = 3;
    } else if (typeOfFlowers === "Gladiolus") {
        if (numberOfFlowers < 80) {
            addPrice = 0.20;
        }
        price = 2.50;
    }
    let totalPrice = (numberOfFlowers * price);
    totalPrice = (totalPrice - (totalPrice * discount)) + (totalPrice * addPrice);
    if (boudget >= totalPrice) {
        let moneyLeft = boudget - totalPrice;
        console.log(`Hey, you have a great garden with ${numberOfFlowers} ${typeOfFlowers} and ${moneyLeft.toFixed(2)} leva left.`);
    } else {
        let moneyNeeds = totalPrice - boudget;
        console.log(`Not enough money, you need ${moneyNeeds.toFixed(2)} leva more.`)
    }
}

newHouse(["Narcissus",
"119",
"360"])


