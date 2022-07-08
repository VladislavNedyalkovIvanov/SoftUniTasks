function fishLand(data) {
    let priceMarckerel = Number(data[0]);
    let priceSprinkle = Number(data[1]);
    let priceBonuto = priceMarckerel + (priceMarckerel * 0.60);
    let priceSafrid = priceSprinkle + (priceSprinkle * 0.80);
    let priceMussels = 7.50;

    let kgBonito = Number(data[2]);
    let kgSafrid = Number(data[3]);
    let kgMussels = Number(data[4]);

    let allCost = (kgBonito * priceBonuto) + (kgSafrid * priceSafrid) + (kgMussels * priceMussels);
    console.log(allCost.toFixed(2));


}
fishLand(["5.55", "3.57", "4.3", "3.6", "7"])