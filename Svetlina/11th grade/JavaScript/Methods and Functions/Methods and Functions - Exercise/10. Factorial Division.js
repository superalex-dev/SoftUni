function factorialDivision(firstNumber, secondNumber){
    let firstFactorial = factorial(firstNumber);
    let secondFactorial = factorial(secondNumber);
    let result = firstFactorial / secondFactorial;
    console.log(result.toFixed(2));
    function factorial(number){
        let factorial = 1;
        for (let i = 1; i <= number; i++) {
            factorial *= i;
        }
        return factorial;
    }
}