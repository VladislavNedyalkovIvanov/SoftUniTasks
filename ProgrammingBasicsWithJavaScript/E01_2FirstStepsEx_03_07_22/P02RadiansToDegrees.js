function radiansToDegrees(input) {
    let radians = Number(input[0]);
    let graduses = (radians * 180) / Math.PI;
    console.log(graduses);
}

radiansToDegrees([6.2832]);