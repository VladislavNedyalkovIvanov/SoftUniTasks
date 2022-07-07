function USDtoBGN(input) {
    let course = 1.79549;
    let numberOfDolars = Number(input[0]);
    let priceInBGN = course * numberOfDolars;
    console.log(`${priceInBGN}`)
}

USDtoBGN(["12.5"])