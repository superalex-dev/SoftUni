function solve(arr, order) {
    if (order === "asc") {
        return arr.sort();
    } else if (order === "desc") {
        return arr.sort().reverse();
    }
}

console.log(solve(['a', 'n', 'k', 'b', 'c'], 'desc'));
console.log(solve(['a', 'n', 'k', 'b', 'c'], 'asc'));