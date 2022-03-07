function calculator(num1, operator, num2) {
    switch (operator.trim()) {
      case '+':
        return num1 + num2
      case '-':
        return num1 - num2
      case '/':
        return num1 / num2
      case '*':
        return num1 * num2
    }
    console.log(operator(Number(num1),Number(num2)));
}
