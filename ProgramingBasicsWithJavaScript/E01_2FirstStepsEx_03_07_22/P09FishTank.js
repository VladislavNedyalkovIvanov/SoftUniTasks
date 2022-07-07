function fishTank(inbox) {
    let length = Number(inbox[0]);
    let width = Number(inbox[1]);
    let height = Number(inbox[2]);
    let percentFull = Number(inbox[3]);
    percentFull = percentFull / 100;

    let allLitres = (length * width * height) / 1000;
    allLitres = allLitres - (allLitres * percentFull);
    console.log(allLitres)
}

fishTank(["105", "77", "89", "18.5"])