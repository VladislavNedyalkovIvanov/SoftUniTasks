function invalidNumber(inbox) {
    let number = parseInt(inbox[0]);

    if (number >= 100 && number <= 200 || number === 0) {
    } else {
        console.log("invalid");
    }
}

invalidNumber(["0"]);