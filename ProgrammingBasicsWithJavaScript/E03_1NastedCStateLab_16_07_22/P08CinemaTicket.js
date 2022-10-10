function cinemaTicket(inbox) {
    let dayOfWeek = (inbox[0]);
    let totalCost = 0;
    switch(dayOfWeek) {
        case "Monday":
        case "Tuesday":
        case "Friday":
            totalCost = 12;
            break;
        case "Wednesday":
        case "Thursday":
            totalCost = 14;
            break;
        case "Saturday":
        case "Sunday":
            totalCost = 16;
            break;
    }
    console.log(totalCost);
}

cinemaTicket(["Sunday"]);