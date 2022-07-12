function passwordGuess(inbox) {
    let password = (inbox[0]);
    if (password === "s3cr3t!P@ssw0rd") {
        console.log("Welcome")
    } else {
        console.log("Wrong password!")
    }
}

passwordGuess(["s3cr3t!p@ss"])