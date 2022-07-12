function greaterNumber(inbox) {
    let number = null;
    let num1 = (inbox[0]);
    let num2 = (inbox[1]);
    if (num1 > num2) {
        console.log(num1);
    } else {
        console.log(num2);
    }
}

greaterNumber(["1", "5"])
