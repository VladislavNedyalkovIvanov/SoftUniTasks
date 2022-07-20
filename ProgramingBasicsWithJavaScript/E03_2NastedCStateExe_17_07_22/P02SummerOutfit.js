function summerOutfit(inbox){
    let degrees = Number(inbox[0]);
    let timeOfDay = (inbox[1]);
    let outfit = null;
    let shoes = null;
    if (degrees >= 10 && degrees <= 18) {
        switch(timeOfDay) {
            case "Morning": outfit = "Sweatshirt"; shoes = "Sneakers"; break;
            case "Afternoon":
            case "Evening": outfit = "Shirt"; shoes = "Moccasins"; break;
        }
    } else if (degrees > 18 && degrees <= 24) {
        switch (timeOfDay) {
            case "Morning": outfit = "Shirt"; shoes = "Moccasins"; break;
            case "Afternoon": outfit = "T-Shirt"; shoes = "Sandals"; break;
            case "Evening": outfit = "Shirt"; shoes = "Moccasins"; break;
        }
    } else if (degrees >= 25) {
        switch (timeOfDay) {
            case "Morning": outfit = "T-Shirt"; shoes = "Sandals"; break;
            case "Afternoon": outfit = "Swim Suit"; shoes = "Barefoot"; break;
            case "Evening": outfit = "Shirt"; shoes = "Moccasins"; break;
        }
    }
    console.log(`It's ${degrees} degrees, get your ${outfit} and ${shoes}.`)
}

summerOutfit(["22",
"Afternoon"])
