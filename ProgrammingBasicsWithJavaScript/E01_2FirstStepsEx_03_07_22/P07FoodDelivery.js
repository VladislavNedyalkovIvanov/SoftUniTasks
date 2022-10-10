function foodDelivery(inbox) {
    let chickenMenu = 10.35;
    let fishMenu = 12.40;
    let vegetarianMenu = 8.15;

    let numberChickenMenu = Number(inbox[0]);
    let numberFishMenu = Number(inbox[1]);
    let numberVegetarianMenu = Number(inbox[2]);

    let allCost = (chickenMenu * numberChickenMenu) + (fishMenu * numberFishMenu) + (vegetarianMenu * numberVegetarianMenu);
    let dessert = allCost * 0.20;
    allCost += dessert + 2.50;

    console.log(allCost)

}

foodDelivery(["9", "2", "6"])