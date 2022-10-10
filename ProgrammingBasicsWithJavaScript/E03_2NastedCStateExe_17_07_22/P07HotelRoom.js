function hotelRoom(inbox) {
    let mount = (inbox[0]);
    let numberOfNights = parseInt(inbox[1]);
    pricePerStudio = 0;
    pricePerApartment = 0;
    if (mount === "May" || mount === "October") {
        pricePerStudio = numberOfNights * 50;
        pricePerApartment = numberOfNights * 65;
    } else if (mount === "June" || mount === "September") {
        pricePerStudio = numberOfNights * 75.20;
        pricePerApartment = numberOfNights * 68.70;
    } else if (mount === "July" || mount === "August") {
        pricePerStudio = numberOfNights * 76;
        pricePerApartment = numberOfNights * 77;
    }
    if ((numberOfNights > 7 && numberOfNights <= 14) && (mount === "May" || mount === "October")) {
        pricePerStudio = pricePerStudio - (pricePerStudio * 0.05);
    } else if ((numberOfNights > 14) && (mount === "May" || mount === "October")) {
        pricePerStudio = pricePerStudio - (pricePerStudio * 0.30);
    } else if ((numberOfNights > 14) && (mount === "June" || mount === "September")) {
        pricePerStudio = pricePerStudio - (pricePerStudio * 0.20);
    } 
    if (numberOfNights > 14) {
        pricePerApartment = pricePerApartment - (pricePerApartment * 0.10);
    }
    console.log(`Apartment: ${pricePerApartment.toFixed(2)} lv.`);
    console.log(`Studio: ${pricePerStudio.toFixed(2)} lv.`);
}

hotelRoom(["August",
"20"])

