function suppliesForSchool(input) {
    let pricePackageChemicals = 5.80;
    let pricePackageMarkers = 7.20;
    let preparationPerLitre = 1.20;
    let numberPackagesChemicals = Number(input[0]);
    let numberPackagesMarkers = Number(input[1]);
    let litresPreparation = Number(input[2]);
    let percentLess = Number(input[3]);
    percentLess = percentLess / 100;
    let allCostWithoutLess = (pricePackageChemicals * numberPackagesChemicals) + (pricePackageMarkers * numberPackagesMarkers) + (preparationPerLitre * litresPreparation)
    let allCost = allCostWithoutLess - (allCostWithoutLess * percentLess);
    console.log(allCost);
}

suppliesForSchool(["4", "2", "5", "13"])