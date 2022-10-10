function vacantionBookList(input) {
    let pagesPerDay = Number(input[0]);
    let pagesPerHour = Number(input[1]);
    let daysForRead = Number(input[2]);
    let neededHoursPerDay = Number(pagesPerDay / pagesPerHour) / daysForRead;
    console.log(neededHoursPerDay);
}

vacantionBookList(["432", "15", "4"]);