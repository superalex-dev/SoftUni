const solution = {
    multiply:
        function(array, multiplier) {
        return array.map(x => x * multiplier);
    },
    multiswap:
        function(array1, array2) {
        return array1[0] * array2[1] - array1[1] * array2[0];
    }
};


console.log(solution.multiply([3.5, -2], 2));
console.log(solution.multiswap([3, 7], [1, 0]));
