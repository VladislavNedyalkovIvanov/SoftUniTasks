function areaOfFigures(inbox) {
    let typeOfObject = (inbox[0]);
    let number1 = (inbox[1]);
    let area = null;
    if (typeOfObject === "square") {
        area = number1 * number1;
    } else if (typeOfObject === "rectangle") {
        let number2 = (inbox[2]);
        area = number1 * number2;
    } else if (typeOfObject === "circle") {
        area = Math.pow(number1, 2) * Math.PI;
    } else if (typeOfObject === "triangle") {
        let number2 = (inbox[2]);
        area = (number1 * number2) / 2;
    }
    console.log(`${area.toFixed(3)}`);
}

areaOfFigures(["triangle",
"4.5",
"20"])

