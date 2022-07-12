function shopping(inbox) {
    let boudgetOfPetar = Number(inbox[0]);
    let videocardNumber = Number(inbox[1]);
    let processorNumber = Number(inbox[2]);
    let ramMemory = Number(inbox[3]);

    let videocardPrice = 250;
    let allForVideocards = videocardNumber * videocardPrice;
    let processorPrice = allForVideocards * 0.35;
    let ramMemoryPrice = allForVideocards * 0.10;
    let allCost = allForVideocards + (processorNumber * processorPrice) + (ramMemory * ramMemoryPrice);
    if (videocardNumber > processorNumber) {
        allCost = allCost - (allCost * 0.15);
    }
    if (boudgetOfPetar >= allCost) {
        let allLeft = boudgetOfPetar - allCost;
        console.log(`You have ${allLeft.toFixed(2)} leva left!`);
    } else {
        let allNeed = allCost - boudgetOfPetar;
        console.log(`Not enough money! You need ${allNeed.toFixed(2)} leva more!`);
    }
}

shopping(["920.45",
"3",
"1",
"1"])

