function palindromeIntegers(array){
    for (let i = 0; i < array.length; i++) {
        let currentNumber = array[i];
        let reversedNumber = Number(currentNumber.toString().split('').reverse().join(''));
        if (currentNumber === reversedNumber){
            console.log('true');
        } else {
            console.log('false');
        }
    }
}
palindromeIntegers([123, 323, 421, 121]);
