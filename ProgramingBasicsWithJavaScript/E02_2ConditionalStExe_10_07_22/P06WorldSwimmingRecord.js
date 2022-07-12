function worldSwimmingRecord(inbox) {
    let recordInSeconds = Number(inbox[0]);
    let distanceInMeters = Number(inbox[1]);
    let timeInSecondsForMeter = Number(inbox[2]);

    let timeAdd = Math.floor(distanceInMeters / 15) * 12.5;
    let timeOfIvan = (distanceInMeters * timeInSecondsForMeter) + timeAdd;

    if (timeOfIvan < recordInSeconds) {
        console.log(`Yes, he succeeded! The new world record is ${timeOfIvan.toFixed(2)} seconds.`)
    } else {
        let timeNeeds = timeOfIvan - recordInSeconds;
        console.log(`No, he failed! He was ${timeNeeds.toFixed(2)} seconds slower.`);
    }

}
worldSwimmingRecord(["55555.67",
"3017",
"5.03"])

