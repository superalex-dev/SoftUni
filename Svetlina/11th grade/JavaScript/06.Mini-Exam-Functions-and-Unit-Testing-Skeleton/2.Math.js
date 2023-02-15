class solution{
    static multiply(array, multiplier){
        let finalObject = [];
        array.forEach(element => {
            finalObject.push(element * multiplier);
        });
        return (finalObject);
    }

    static multiswap(array1, array2){
        let finalObject = [];
        return (array1[0] * array2[1] - array2[0] * array1[1]);
    }
}


//class Solution {
//     static multiply(arr, multiplier) {
//         return arr.map(num => num * multiplier);
//     }
//
//     static multiswap([a, b], [c, d]) {
//         return a * d - b * c;
//     }
// }


console.log(solution.multiply([3.5, -2], 2));
console.log(solution.multiswap([3, 7], [1, 0]));
