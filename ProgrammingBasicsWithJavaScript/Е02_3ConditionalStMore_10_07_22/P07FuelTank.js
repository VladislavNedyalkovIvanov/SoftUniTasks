function fuelTank(inbox){
    let fuel = (inbox[0]);
    let litresFuel = Number(inbox[1]);
    if (fuel === "Diesel" || fuel === "Gasoline" || fuel === "Gas") {
        fuel = fuel.toLowerCase();
        if (litresFuel >= 25) {
            console.log(`You have enough ${fuel}.`);
        } else {
            console.log(`Fill your tank with ${fuel}!`)
        } 
    } else {
        console.log("Invalid fuel!");
    }
}

fuelTank(["Kerosine", "200"])