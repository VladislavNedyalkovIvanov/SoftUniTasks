function godzillaVsKong(inbox) {
    let boudgetOfMovie = Number(inbox[0]);
    let numberOfStatist = Number(inbox[1]);
    let priceDressStatist = Number(inbox[2]);

    let decorForMovie = boudgetOfMovie * 0.10;
    let priceAllDress = numberOfStatist * priceDressStatist;

    if (numberOfStatist > 150) {
        priceAllDress = priceAllDress - (priceAllDress * 0.10);
    }

    let allCostForMovie = priceAllDress + decorForMovie

    if (allCostForMovie > boudgetOfMovie) {
        let allNeed = allCostForMovie - boudgetOfMovie;
        console.log(`Not enough money!`);
        console.log(`Wingard needs ${allNeed.toFixed(2)} leva more.`);
    } else {
        let allLeft = boudgetOfMovie - allCostForMovie;
        console.log(`Action!`);
        console.log(`Wingard starts filming with ${allLeft.toFixed(2)} leva left.`);
    }
}

godzillaVsKong(["9587.88",
"222",
"55.68"])


