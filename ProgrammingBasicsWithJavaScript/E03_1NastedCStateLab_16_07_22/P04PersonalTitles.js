function personalTitles(inbox) {
    let years = Number(inbox[0]);
    let gender = (inbox[1]);
    if (years >= 16) {
        switch (gender) {
            case "m":
                console.log("Mr.");
                break;
            case "f":
                console.log("Ms.");
                break;
        }
    } else if (years < 16) {
        switch (gender) {
            case "m":
                console.log("Master");
                break;
            case "f":
                console.log("Miss");
                break;
        }
    }
}

personalTitles(["13.5", "m"])