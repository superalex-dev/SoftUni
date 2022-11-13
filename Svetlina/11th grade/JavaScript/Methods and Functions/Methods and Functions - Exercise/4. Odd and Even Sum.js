function oddAndEvenSum(number){
    let oddSum = 0;
    let evenSum = 0;
    let numberToString = number.toString();
    for (let i = 0; i < numberToString.length; i++) {
        let currentNumber = Number(numberToString[i]);
        if (currentNumber % 2 === 0){
            evenSum += currentNumber;
        } else {
            oddSum += currentNumber;
        }
    }
    console.log(`Odd sum = ${oddSum}, Even sum = ${evenSum}`);
}
oddAndEvenSum(1000435);