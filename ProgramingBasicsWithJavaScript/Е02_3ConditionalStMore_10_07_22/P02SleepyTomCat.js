function sleepyTom(inbox) {
    let normForPlay = 30000;
    let minutesPlayWorkDays = 63;
    let minutesPlayWeekDays = 127;
    let freeDays = (inbox[0]);
    let workDays = 365 - freeDays;
    minutesPlayWorkDays = minutesPlayWorkDays * workDays;
    minutesPlayWeekDays = minutesPlayWeekDays * freeDays;
    let allMinutesPlay = minutesPlayWeekDays + minutesPlayWorkDays;
    if (allMinutesPlay > normForPlay) {
        let minutesMore = allMinutesPlay - normForPlay;
        let hoursMore = parseInt(minutesMore / 60);
        minutesMore = parseInt(minutesMore % 60);
        console.log(`Tom will run away`);
        console.log(`${hoursMore} hours and ${minutesMore} minutes more for play`);
    } else {
        let minutesLess = normForPlay - allMinutesPlay;
        let hoursLess = parseInt(minutesLess / 60);
        minutesLess = parseInt(minutesLess % 60);
        console.log(`Tom sleeps well`);
        console.log(`${hoursLess} hours and ${minutesLess} minutes less for play`);
    }
}

sleepyTom(["113"]);