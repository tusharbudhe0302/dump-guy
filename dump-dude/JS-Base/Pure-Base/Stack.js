/**Stack : LIFO 
 * List of operation performed by Stack
        push(): Adds an item at of the stack.
        pop(): Removes an item from the head of the stack.
        peek(): Retruns the last item in the stack.
        rear(): Retruns the last item in the stack.
        size(): Returns the size of the stack.
        isEmpty(): Returns true if stack is empty, false otherwise.
*/
var Stack = function (size) {
    this.elements = [size];
    this.top = -1;
    this.maxSize = size;
}
Stack.prototype.push = function (value) {
    if (this.isFull()) {
        console.log(`Stack Overflow!`);
        return;
    }
    this.top++;
    // console.log(`this.top : ${this.top}`);
    this.elements[this.top] = value;
}
Stack.prototype.getLength = function () {
    return this.top + 1;
}
Stack.prototype.peek = function () {
    return this.elements[this.top];
}
Stack.prototype.pop = function () {
    if (this.isEmpty()) {
        console.log(`Stack Is empty`);
        return -1;
    }
    this.top--;
}
Stack.prototype.isFull = function () {
    if (this.getLength() === this.maxSize)
        return true;
    else
        return false;
}
Stack.prototype.isEmpty = function () {
    if (this.top == -1)
        return true;
    else
        return false;
}
Stack.prototype.getIndexOfItem = function (value) {
    return this.elements.filter((item, i) => {
        if (item == value)
            return i;
    });
}
Stack.prototype.printStack = function () {
    console.log(`Current Stack : ${this.elements} `);
}
var myJsStack = new Stack(4);
myJsStack.push(1);
myJsStack.push(2);
myJsStack.push(3);
myJsStack.push(4);
myJsStack.printStack();
console.log(`Stack length : ${myJsStack.getLength()}`);
console.log(`Stack isFull : ${myJsStack.isFull()}`);
myJsStack.push(5);
console.log(`Stack Peek : ${myJsStack.peek()}`);
myJsStack.pop();
console.log(`Stack length : ${myJsStack.getLength()}`);
console.log(`Stack isEmpty : ${myJsStack.isEmpty()}`);
myJsStack.pop()
myJsStack.pop()
myJsStack.pop()
console.log(`Stack isEmpty : ${myJsStack.isEmpty()}`);


// Design a max stack that supports push, pop, top, peekMax and popMax.

// push(x) -- Push element x onto stack.
// pop() -- Remove the element on top of the stack and return it.
// top() -- Get the element on the top.
// peekMax() -- Retrieve the maximum element in the stack.
// popMax() -- Retrieve the maximum element in the stack, and remove it. If you find more than one maximum elements, only remove the top-most one.

/**
 * initialize your data structure here.
 */
var MaxStack = function () {
    this.elements = [];
};

/** 
* @param {number} x
* @return {void}
*/
MaxStack.prototype.push = function (x) {
    this.elements.push(x);
    return x;
};

/**
* @return {number}
*/
MaxStack.prototype.pop = function () {
    var result = this.elements[this.elements.length - 1];
    delete this.elements.pop();
    return result;
};

/**
* @return {number}
*/
MaxStack.prototype.top = function () {
    console.log(`this.elements : ${this.elements}`);
    if ((this.elements.length - 1) >= 0)
        return this.elements[this.elements.length - 1];
    else
        return null;
};

/**
* @return {number}
*/
MaxStack.prototype.peekMax = function () {
    let maxPeek = Math.max.apply(null, this.elements);
    return maxPeek;
};

/**
* @return {number}
*/
MaxStack.prototype.popMax = function () {

    let maxPop = Math.max.apply(null, this.elements);
    let maxPopIndex = this.elements.indexOf(maxPop);
    delete this.elements[maxPopIndex];
    return maxPop;

};

/**
* Your MaxStack object will be instantiated and called as such:

*/

var obj = new MaxStack()
obj.push(5)
obj.push(1);
obj.push(7);
console.log(`this.elements : ${obj.elements}`);
var param_2 = obj.pop()
var param_3 = obj.top()
var param_4 = obj.peekMax()
var param_5 = obj.popMax()
console.log(` param_2: ${param_2} param_3: ${param_3} param_4 : ${param_4} param_5: ${param_5}`);