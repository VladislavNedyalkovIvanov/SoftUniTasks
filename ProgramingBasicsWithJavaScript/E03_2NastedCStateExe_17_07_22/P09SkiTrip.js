function skiTrip(inbox) {
    let dayPerstay = Number(inbox[0]);
    let typeOfRoom = (inbox[1]);
    let assessment = (inbox[2]);
    let allPay = 0;
    let pricePerNight = 0;
    let discount = 0;
    if (typeOfRoom === "room for one person") {
        pricePerNight = 18.00;
    } else if (typeOfRoom === "apartment") {
        pricePerNight = 25.00;
        if (dayPerstay < 10) {
            discount = 0.30;
        } else if (dayPerstay >= 10 && dayPerstay <= 15) {
            discount = 0.35;
        } else {
            discount = 0.50;
        }
    } else if (typeOfRoom === "president apartment") {
        pricePerNight = 35.00;
        if (dayPerstay < 10) {
            discount = 0.10;
        } else if (dayPerstay >= 10 && dayPerstay <= 15) {
            discount = 0.15;
        } else {
            discount = 0.20;
        }
    }
    let nightStay = dayPerstay - 1;
    allPay = nightStay * pricePerNight;
    allPay = allPay - (allPay * discount);
    if (assessment === "positive") {
        allPay = allPay + (allPay * 0.25);
    } else {
        allPay = allPay - (allPay * 0.10);
    }
    console.log(`${allPay.toFixed(2)}`);
}

skiTrip(["2",
"apartment",
"positive"])

