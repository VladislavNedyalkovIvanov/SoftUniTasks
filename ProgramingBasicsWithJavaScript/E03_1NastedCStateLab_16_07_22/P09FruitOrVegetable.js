function fruitOrVegetable(inbox) {
    let typeOfProduct = (inbox[0]);
    let product = "unknown";
    switch(typeOfProduct) {
        case "banana":
        case "apple":
        case "kiwi":
        case "cherry":
        case "lemon":
        case "grapes":
            product = "fruit";
            break;
        case "tomato":
        case "cucumber":
        case "pepper":
        case "carrot":
            product = "vegetable";
            break;
    }
    console.log(product);
}

fruitOrVegetable(["water"])