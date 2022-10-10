function triangleArea(input) {
    let a = Number(input[0]);
    let h = Number(input[1]);
    let faceOfTriangle = (a * h) / 2;
    console.log(`${faceOfTriangle.toFixed(2)}`);
}

triangleArea(["1.23456", "4.56789"]);