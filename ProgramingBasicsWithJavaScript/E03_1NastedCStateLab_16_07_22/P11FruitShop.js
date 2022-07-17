function fruitShop(inbox) {
    let fruit = (inbox[0]);
    let dayOfWeek = (inbox[1]);
    let quantity = (inbox[2]);
    let price = null;
    let result = null;
    switch (dayOfWeek) {
        case "Monday":
        case "Tuesday":
        case "Wednesday":
        case "Thursday":
        case "Friday":
            switch (fruit) {
                case "banana":  price = 2.50;   break;
                case "apple":   price = 1.20;   break;
                case "orange":  price = 0.85;   break;
                case "grapefruit":  price = 1.45;   break;
                case "kiwi":    price = 2.70;   break;
                case "pineapple":   price = 5.50;   break;
                case "grapes":  price = 3.85;   break;
            }
    }
    switch (dayOfWeek) {
        case "Saturday":
        case "Sunday":
            switch (fruit) {
                case "banana":  price = 2.70;   break;
                case "apple":   price = 1.25;   break;
                case "orange":  price = 0.90;   break;
                case "grapefruit":  price = 1.60;   break;
                case "kiwi":    price = 3.00;   break;
                case "pineapple":   price = 5.60;   break;
                case "grapes":  price = 4.20;   break;
            }
    }
if (price != null) {
    result = Number(price * quantity);
    console.log(`${result.toFixed(2)}`);
} else {
    result = "error";
    console.log(result);
}
}
