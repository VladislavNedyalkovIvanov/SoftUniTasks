function fuelTankPart2(inbox) {
    let pricePerLitreGasoline = 2.22;
    let pricePerLitreDiesel = 2.33;
    let pricePerLitreGas = 0.93;

    let typeOfFuel = (inbox[0]);
    let litresFuel = (inbox[1]);
    let clubCard = (inbox[2]);
    let allCost = null;

    if (clubCard === "Yes") {
        pricePerLitreGasoline -= 0.18;
        pricePerLitreDiesel -= 0.12;
        pricePerLitreGas -= 0.08;
    }
    if (typeOfFuel === "Gasoline") {
        allCost = (litresFuel * pricePerLitreGasoline);
    } else if (typeOfFuel === "Diesel") {
        allCost = (litresFuel * pricePerLitreDiesel);
    } else if (typeOfFuel === "Gas") {
        allCost = (litresFuel * pricePerLitreGas);
    }

    if (litresFuel >= 20 && litresFuel <= 25) {
        allCost = allCost - (allCost * 0.08);
    } else if (litresFuel > 25) {
        allCost = allCost - (allCost * 0.10);
    }
    console.log(`${allCost.toFixed(2)} lv.`);
}

fuelTankPart2(["Diesel", "19", "No"])