function pipesInPool(inbox) {
    let vPool = Number(inbox[0]);
    let p1 = Number(inbox[1]);
    let p2 = Number(inbox[2]);
    let hoursLeft = Number(inbox[3]);

    let p1Water = p1 * hoursLeft;
    let p2Water = p2 * hoursLeft;
    let waterFull = p1Water + p2Water;

    let percentP1Water = (p1Water / waterFull) * 100;
    let percentP2Water = (p2Water / waterFull) * 100;

    if (waterFull <= vPool) {
        let percentPoolLeft = (waterFull / vPool) * 100;
        console.log(`The pool is ${percentPoolLeft.toFixed(2)}% full. Pipe 1: ${percentP1Water.toFixed(2)}%. Pipe 2: ${percentP2Water.toFixed(2)}%.`);
    } else {
        let litresMore = waterFull - vPool;
        console.log(`For ${hoursLeft.toFixed(2)} hours the pool overflows with ${litresMore.toFixed(2)} liters.`);
    }
}

pipesInPool(["100", "100", "100", "2.5"])