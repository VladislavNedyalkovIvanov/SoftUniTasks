function housePaiting(data) {
    let greenPaintMetersPerL = 3.4;
    let redPaintMetersPerL = 4.3;

    let x = (data[0]);
    let y = (data[1]);
    let h = (data[2]);

    let frondAndBackWall = (x * x) * 2;
    let doorSize = 1.2 * 2;
    frondAndBackWall -= doorSize;

    let readWalls = (x * y) * 2;
    let windowsSize = (1.5 * 1.5) * 2;  // 2 windows x 1 each side;
    readWalls -= windowsSize;

    let AllWalls = readWalls + frondAndBackWall;
    let greenPaintNeed = AllWalls / greenPaintMetersPerL;

    let roofSize1 = (x * y) * 2;
    let roofSize2 = ((x * h) / 2) * 2;
    let roofSize = roofSize1 + roofSize2;
    let redPaintNeed = roofSize / redPaintMetersPerL;

    console.log(greenPaintNeed.toFixed(2));
    console.log(redPaintNeed.toFixed(2));
}

housePaiting(["6", "10", "5.2"]);