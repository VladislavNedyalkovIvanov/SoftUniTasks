function trainingLabs(inbox) {
    let w = Number(inbox[0]);
    let h = Number(inbox[1]);

    let wInSantimeters = w * 100;
    let hInSantimeters = h * 100;
    let coridor = 100;
    hInSantimeters -= coridor;

    let workPlacesInH = hInSantimeters / 70;
    workPlacesInH = Math.floor(workPlacesInH);
    let workPlacesInW = wInSantimeters / 120;
    workPlacesInW = Math.floor(workPlacesInW);

    let placesForDepartmentAndDoor = 2 + 1;  

    let allWorkingPlaces = (workPlacesInH * workPlacesInW) - placesForDepartmentAndDoor;

    console.log(allWorkingPlaces);
}

trainingLabs(["8.4", "5.2"]);