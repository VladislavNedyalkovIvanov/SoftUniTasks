function onTimeForTheExam(inbox) {
    let hourOfExam = Number(inbox[0]);
    let minuteOfExam = Number(inbox[1]);
    let hourOfIncoming = Number(inbox[2]);
    let minuteOfIncoming = Number(inbox[3]);
    let allExamTimeInMinutes = (hourOfExam * 60) + minuteOfExam;
    let allIncomingTimeInMinutes = (hourOfIncoming * 60) + minuteOfIncoming;
    let timeEarly = 0;
    let timeLate = 0;
    if (allExamTimeInMinutes >= allIncomingTimeInMinutes) {
        timeEarly = allExamTimeInMinutes - allIncomingTimeInMinutes;
        if (timeEarly > 30 && timeEarly < 60){
            console.log("Early");
            console.log(`${timeEarly} minutes before the start`);
        } else if (timeEarly >= 60) {
            console.log("Early");
            let hoursEarly = parseInt(timeEarly / 60);
            let minutesEarly = timeEarly % 60;
            if (minutesEarly < 10) {
                console.log(`${hoursEarly}:0${minutesEarly} hours before the start`);
            } else {
                console.log(`${hoursEarly}:${minutesEarly} hours before the start`);
            }
            
        } else if (timeEarly === 0) {
            console.log("On time")
        } else if (timeEarly <= 30) {
            console.log("On time");
            console.log((`${timeEarly} minutes before the start`));
        }
    } else {
        timeLate = allIncomingTimeInMinutes - allExamTimeInMinutes;
         if (timeLate < 60) {
            console.log("Late");
            console.log(`${timeLate} minutes after the start`);
        } else if (timeLate >= 60) {
            console.log("Late");
            let hoursLate = parseInt(timeLate / 60);
            let minutesLate = timeLate % 60;
            if (minutesLate < 10) {
                console.log(`${hoursLate}:0${minutesLate} hours after the start`);
            } else {
                console.log(`${hoursLate}:${minutesLate} hours after the start`);
            }
        }
    }
}

onTimeForTheExam(["11",
"30",
"12",
"29"])









