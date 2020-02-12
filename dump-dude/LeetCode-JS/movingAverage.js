/**
 * Initialize your data structure here.
 * @param {number} size
 */
let maxCounter = -1;
let negativeCount = 0;
var MovingAverage = function (size) {
    this.elments = [];
    maxCounter = size;
};

/** 
 * @param {number} val
 * @return {number}
 */
MovingAverage.prototype.next = function (val) {
    if (maxCounter < 0) return val / 1;
    if (maxCounter > this.elments.length) {
        this.elments.push(val);
    } else {
        this.elments.shift();
        this.elments.push(val);
    }
    let sum = 0;
    this.elments.map((num, i) => {
        sum += num;
        if (Math.sign(num) < 0) {
            negativeCount++;
        }
    })
    console.log(`sum : ${sum} negativeCount : ${negativeCount} `);
    let result = Math.abs(sum / this.elments.length)
    if (negativeCount % 2 > 0) {
        result = "-" + result;
    }
    return result
};

/** 
 * Your MovingAverage object will be instantiated and called as such:
 * var obj = new MovingAverage(size)
 * var param_1 = obj.next(val)
 */

// let m = new MovingAverage(3);
// console.log(m.next(1));// = 1
// console.log(m.next(10));// =  (1 + 10) / 2
// console.log(m.next(3)); //= (1 + 10 + 3) / 3
// console.log(m.next(5)); // = (10 + 3 + 5) / 3

let m = new MovingAverage(1);
console.log(m.next(4));// = 1
console.log(m.next(0));
// console.log(m.next(-5));// = 1
// console.log(m.next(-1));// = 1