function sumSeconds(inbox) {
    let number1 = Number(inbox[0]);
    let number2 = Number(inbox[1]);
    let number3 = Number(inbox[2]);
    let totalTimeInSeconds = number1 + number2 + number3;
    let timeInMinutes = parseInt(totalTimeInSeconds / 60);
    let timeInSeconds = parseInt(totalTimeInSeconds % 60);
    if (timeInSeconds < 10) {
        console.log(`${timeInMinutes}:0${timeInSeconds}`);
    } else {
        console.log(`${timeInMinutes}:${timeInSeconds}`);
    }
}

sumSeconds(["14", "12",
"10"])

