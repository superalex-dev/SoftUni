function calculateSugarIntake(days) {
    const dailyIntake = {
        cookies: {
            sugar: 5,
            weight: 25,
            count: 2
        },
        waffles: {
            sugar: 18,
            weight: 50,
            count: 1
        },
        cupcakes: {
            sugar: 20,
            weight: 25,
            count: 3
        }
    }

    let totalSugar = 0;
    for (let i = 1; i <= days; i++) {
        totalSugar += dailyIntake.cookies.sugar * dailyIntake.cookies.weight * dailyIntake.cookies.count / 100;
        totalSugar += dailyIntake.waffles.sugar * dailyIntake.waffles.weight * dailyIntake.waffles.count / 100;
        if (i % 5 === 0) {
            totalSugar += dailyIntake.cupcakes.sugar * dailyIntake.cupcakes.weight * dailyIntake.cupcakes.count / 100;
        }
    }

    return `You have consumed ${totalSugar} grams of sugar`;
}



console.log(calculateSugarIntake(1)); // You have consumed 11.5 grams of sugar
console.log(calculateSugarIntake(9)); // You have consumed 118.5 grams of sugar
