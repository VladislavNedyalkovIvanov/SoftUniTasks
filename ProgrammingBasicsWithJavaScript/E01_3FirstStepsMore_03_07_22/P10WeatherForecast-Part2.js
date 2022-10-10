function weatherForefast2(data) {
    let input = Number(data[0]);
    if (input <= 35.00 && input >= 26.00) {
        console.log("Hot");
    }
    else if (input <= 25.9 && input >= 20.1) {
        console.log("Warm");
    }
    else if (input <= 20.00 && input >= 15.00) {
        console.log("Mild");
    }
    else if (input <= 14.9 && input >= 12.00) {
        console.log("Cool");
    }
    else if (input <= 11.9 && input >= 5.00) {
        console.log("Cold");
    }
    else {
        console.log("unknown");
    }
}

weatherForefast2(["0"]);