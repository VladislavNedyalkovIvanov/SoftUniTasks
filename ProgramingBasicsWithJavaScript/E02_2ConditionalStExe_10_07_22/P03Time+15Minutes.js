function timeWith15Minutes(inbox) {
    let hours = Number(inbox[0]);
    let minutes = Number(inbox[1]);
    let allInMinutes = (hours * 60) + minutes + 15;
    hours = parseInt(allInMinutes / 60);
    minutes = parseInt(allInMinutes % 60);
    if (hours >= 24) {
        hours = hours - 24;
    } if (minutes < 10) {
        console.log(`${hours}:0${minutes}`);
    } else {
        console.log(`${hours}:${minutes}`);
    }
}
timeWith15Minutes(["12", "49"])