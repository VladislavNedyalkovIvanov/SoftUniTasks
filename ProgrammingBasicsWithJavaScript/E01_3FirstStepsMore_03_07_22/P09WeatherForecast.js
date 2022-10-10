function weatherForecast(data) {
    let input = (data[0]);
    if (input == "sunny") {
        console.log("It's warm outside!");
    }
    else if (input == "cloudy") {
        console.log("It's cold outside!");
    }
    else {
        console.log("It's cold outside!");
    }
}

weatherForecast(["snowy"])