function expand(regex) {
    const factorial = n => n < 2
        ? 1 : n * factorial(n - 1);
    let result = '', [_, a, x, b, n] =
        regex.match(/\((-?\d*)([a-z])([-+]\d+)\)\^(\d+)/);

    a = a ? a == '-'
        ? -1 : parseInt(a) : 1;
    b = parseInt(b); n = parseInt(n);

    for (let i = n; i >= 0; i--) {
        let k = n - i;
        let c = !b && k > 0 ? 0 : a**i * b**k * (k == 0 ? 1 : factorial(n) / (factorial(k) * factorial(n - k)));

        if (Math.abs(c) == 1 && i > 0) c = c > 0
            ? '+' : '-';
        else c = c > 0
            ? `+${c}` : c;
        if (c) result += c;

        if (i > 0 && c)
        {
            result += x;
        }
        if (i > 1 && c)
        {
            result += `^${i}`;
        }
    }

    console.log(result[0] == '+'
        ? result.substring(1) : result);
}

expand("(-12t+43)^2");