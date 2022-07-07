function basketballEquip(inbox) {
    let yearTaxBasketball = Number(inbox[0]);
    let basketballShoes = yearTaxBasketball - yearTaxBasketball * 0.40;
    let basketballEquip = basketballShoes - basketballShoes * 0.20;
    let basketBall =  basketballEquip / 4;
    let basketAccessoaries = basketBall / 5;

    let allCost = yearTaxBasketball + basketballShoes + basketballEquip + basketBall + basketAccessoaries;
    console.log(allCost)

}

basketballEquip(["365"]);