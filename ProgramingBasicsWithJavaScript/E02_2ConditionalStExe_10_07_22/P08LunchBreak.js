function lunchBreak(inbox) {
    let nameOfMovie = (inbox[0]);
    let timeForEpisode = Number(inbox[1]);
    let timeForResting = Number(inbox[2]);
    let timeForLunch = timeForResting / 8;
    let timeForRest = timeForResting / 4;
    timeForResting = timeForResting - (timeForLunch + timeForRest);

    if (timeForResting >= timeForEpisode) {
        let timeLeft = timeForResting - timeForEpisode;
        console.log(`You have enough time to watch ${nameOfMovie} and left with ${Math.ceil(timeLeft)} minutes free time.`);
    } else {
        let timeNeeds = timeForEpisode - timeForResting;
        console.log(`You don't have enough time to watch ${nameOfMovie}, you need ${Math.ceil(timeNeeds)} more minutes.`);
    }
}

lunchBreak(["Teen Wolf",
"48",
"60"])
