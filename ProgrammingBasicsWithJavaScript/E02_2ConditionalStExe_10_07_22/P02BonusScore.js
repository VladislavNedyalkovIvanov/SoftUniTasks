function bonusScore(inbox) {
    let bonus = Number(inbox[0]);
    let bonusAdd = null;
    if (bonus <= 100) {
        bonusAdd= 5;
    } else if (bonus > 100 && bonus < 1000) {
        bonusAdd = bonus * 0.20;
    } else {
        bonusAdd = bonus * 0.10;
    }
    if (bonus % 2 === 0) {
        bonusAdd += 1;
    } else if (bonus % 10 === 5) {
        bonusAdd += 2;
    }
    bonus += bonusAdd;
    console.log(bonusAdd);
    console.log(bonus);
}
bonusScore(["15875"])