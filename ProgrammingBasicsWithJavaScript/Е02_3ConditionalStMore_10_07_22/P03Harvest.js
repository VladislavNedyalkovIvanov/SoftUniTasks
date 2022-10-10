function harvest(inbox) {
    let x = Number(inbox[0]);
    let yGrapeFromX = Number(inbox[1]);
    let zNeededWine = Number(inbox[2]);
    let workers = Number(inbox[3]);

    let wineYard = x * 0.40;
    let grapesAll = yGrapeFromX * wineYard;
    let litresWine = grapesAll / 2.5;

    if (litresWine < zNeededWine) {
        let moreWine = zNeededWine - litresWine;
        console.log(`It will be a tough winter! More ${Math.floor(moreWine)} liters wine needed.`);
    } else {
        let wineLeft = litresWine - zNeededWine;
        let winePerWorker = wineLeft / workers;
        console.log(`Good harvest this year! Total wine: ${Math.floor(litresWine)} liters.`);
        console.log(`${Math.ceil(wineLeft)} liters left -> ${Math.ceil(winePerWorker)} liters per person.`);
    }
}
harvest(["1020", "1.5", "425", "4"])