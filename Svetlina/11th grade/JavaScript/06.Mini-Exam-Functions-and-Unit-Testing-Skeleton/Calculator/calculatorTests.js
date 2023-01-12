const createCalculator = require('./calculator.js');

const assert = require('assert');

describe("Calculator Tests", () => {
    it("add() should return the sum of two arrays", () => {
        assert.deepEqual(createCalculator.add([1, 1], [1, 0]), [2, 1]);
    });
    it("length() should return the square root of the sum of squares of each number in the array", () => {
        assert.equal(createCalculator.length([3, -4]), 5);
    });
});
