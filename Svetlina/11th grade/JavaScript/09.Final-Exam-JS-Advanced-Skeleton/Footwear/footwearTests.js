const assert = require('assert');
const footwear = require('./footwear');

describe("Tests", () => {
    describe('generateOrder()', () => {
        it('should return an order message when at least one pair of shoes and laces are ordered', () => {
            const order = { orderedShoes: 'Sneakers', orderedLaces: 'Red Laces' };
            const result = footwear.generateOrder(order);
            assert.equal(result, 'Your order contains Sneakers and Red Laces.');
        });
        it('should return an order message when at least one pair of shoes is ordered and no laces are ordered', () => {
            const order = { orderedShoes: 'Sneakers' };
            const result = footwear.generateOrder(order);
            assert.equal(result, 'Your order contains Sneakers');
        });

        it('should throw an error when no shoes are ordered', () => {
            const order = { orderedLaces: 'Red Laces' };
            assert.throws(() => footwear.generateOrder(order), Error, 'You must order at least one pair of shoes.');
        });
    });

    describe('orderStatus()', () => {
        it('should apply a 10% discount and return the final amount of the order if the status is "New"', () => {
            const startingAmount = 100;
            const status = 'New';
            const result = footwear.orderStatus(startingAmount, status);
            assert.equal(result, 90);
        });
        it('should return the final amount of the order if the status is "Delivery"', () => {
            const startingAmount = 100;
            const status = 'Delivery';
            const result = footwear.orderStatus(startingAmount, status);
            assert.equal(result, 100);
        });
        it('should return undefined if the order is invalid ', () => {
            const startingAmount = 100;
            const status = 'Invalid';
            const result = footwear.orderStatus(startingAmount, status);
            assert.equal(result, undefined);
        });
    });
});