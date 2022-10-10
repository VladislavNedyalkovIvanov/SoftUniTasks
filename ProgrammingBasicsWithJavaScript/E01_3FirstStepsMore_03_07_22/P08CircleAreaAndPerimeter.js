function cicleAreaAndPerimeter(data) {
    let r = Number(data[0]);
    let side = Math.PI * (r * r);
    let perimeter = 2 * Math.PI * r;

    console.log(side.toFixed(2));
    console.log(perimeter.toFixed(2));
}

cicleAreaAndPerimeter(["4.5"])