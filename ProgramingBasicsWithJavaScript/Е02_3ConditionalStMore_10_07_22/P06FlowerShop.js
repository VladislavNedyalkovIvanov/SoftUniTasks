function flowerShop(inbox) {
    let priceMagnolias = 3.25;
    let priceHyacinths = 4;
    let priceRouses = 3.50;
    let priceCactus = 8;

    let numberMagnolias = Number(inbox[0]);
    let numberHyacinths = Number(inbox[1]);
    let numberRouses = Number(inbox[2]);
    let numberCactus = Number(inbox[3]);
    let priceForGift = Number(inbox[4]);

    let allProof = (numberMagnolias * priceMagnolias) + (numberHyacinths * priceHyacinths) + (numberRouses * priceRouses) + (numberCactus * priceCactus);
    allProof = allProof - (allProof * 0.05);
    if (allProof >= priceForGift) {
        let allLeft = allProof - priceForGift;
        console.log(`She is left with ${Math.floor(allLeft)} leva.`);
    } else {
        let allNeed = priceForGift - allProof;
        console.log(`She will have to borrow ${Math.ceil(allNeed)} leva.`);
    }
}

flowerShop(["15", "7", "5", "10", "100"])