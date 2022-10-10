function workingHours(inbox) {
    let hour = Number(inbox[0]);
    let dayOfWeek = (inbox[1]);
    let openOrClosed = "closed";
    if (hour >= 10 && hour <= 18) {
        switch(dayOfWeek) {
            case "Monday":
            case "Tuesday":
            case "Wednesday":
            case "Thursday":
            case "Friday":
            case "Saturday":
                openOrClosed = "open";
                break;
        }
    } 
     console.log(openOrClosed);
}

workingHours(["11",
"Sunday"])
