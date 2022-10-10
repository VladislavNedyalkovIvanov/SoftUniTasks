function operationBetweenNumbers(inbox) {
    let n1 = Number(inbox[0]);
    let n2 = Number(inbox[1]);
    let operator = (inbox[2]);
    let result = 0;
    let evenOrOdd = null;
    if (operator === '+' || operator === '-' || operator === '*') {
        switch (operator) {
            case '+': result = n1 + n2; evenOrOdd = result % 2; break;
            case '-': result = n1 - n2; evenOrOdd = result % 2; break;
            case '*': result = n1 * n2; evenOrOdd = result % 2; break;
        }
        if (evenOrOdd === 0) {
            evenOrOdd = "even";
        } else {
            evenOrOdd = "odd"
        }
        console.log(`${n1} ${operator} ${n2} = ${result} - ${evenOrOdd}`);
    } else if (operator === '/') {
        if (n2 === 0) {
            console.log(`Cannot divide ${n1} by zero`);
        } else {
            result = n1 / n2;
            console.log(`${n1} / ${n2} = ${result.toFixed(2)}`);
        }

    } else if (operator === '%') {
        if (n2 === 0) {
            console.log(`Cannot divide ${n1} by zero`);
        } else {
            result = n1 % n2;
            console.log(`${n1} % ${n2} = ${result}`)
        }

    }
}
    operationBetweenNumbers(["7",
    "3",
    "*"])
    
    
       