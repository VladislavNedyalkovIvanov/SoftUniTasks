function repainting(input) {
    let priceProtectiveNylon = 1.50;
    let pricePerLitrePaint = 14.50;
    let pricePerLitreThinner = 5.00;
    
    let neededProtectiveNylon = Number(input[0]) + 2;
    let neededLitresPaint = Number(input[1]);
    neededLitresPaint += neededLitresPaint * 0.1;
    let neededLitresThinner = Number(input[2]);
    let hoursForAllWork = Number(input[3]);

    let allCostWithoutAdd = (priceProtectiveNylon * neededProtectiveNylon) + (pricePerLitrePaint * neededLitresPaint) + (pricePerLitreThinner * neededLitresThinner)
    allCostWithoutAdd += 0.40;
    let pricePerHourWork = allCostWithoutAdd * 0.30;
    allCost = allCostWithoutAdd + (pricePerHourWork * hoursForAllWork);

    console.log(allCost)

}

repainting(["5", "10", "10", "1"]);