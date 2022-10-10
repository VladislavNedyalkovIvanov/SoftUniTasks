function journey(inbox) {
    let boudget = Number(inbox[0]);
    let season = (inbox[1]);
    let destination = null;
    let priceForHolyday = 0;
    let typeOfHolyday = null;
    if (boudget <= 100) {
        destination = "Bulgaria";
        switch(season) {
            case "summer": typeOfHolyday = "Camp"; priceForHolyday = 0.30; break;
            case "winter": typeOfHolyday = "Hotel"; priceForHolyday = 0.70; break;
        }
    } else if (boudget <= 1000) {
        destination = "Balkans";
        switch(season) {
            case "summer": typeOfHolyday = "Camp"; priceForHolyday = 0.40; break;
            case "winter": typeOfHolyday = "Hotel"; priceForHolyday = 0.80; break;
        }
    } else {
        destination = "Europe";
        typeOfHolyday = "Hotel";
        priceForHolyday = 0.90;
    }
    let allCost = boudget * priceForHolyday;
    console.log(`Somewhere in ${destination}`);
    console.log(`${typeOfHolyday} - ${allCost.toFixed(2)}`);
}

journey(["1500", "summer"])