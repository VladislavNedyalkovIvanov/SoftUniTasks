function depositCalculator(input) {
    let depositSum = Number(input[0]);
    let termOfDeposit = parseInt(input[1]);
    let yearAddPercent = Number(input[2]);
    yearAddPercent = yearAddPercent / 100;
    let allSum = depositSum + termOfDeposit * ((depositSum * yearAddPercent) / 12);
    console.log(allSum);
}

depositCalculator(["2350", "6", "7"])