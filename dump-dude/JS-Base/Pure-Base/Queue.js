/**Queue : FIFO
 * List of operation performed by queue
        enqueue(): Adds an item at the tail of the queue.
        dequeue(): Removes an item from the head of the queue.
        front(): Retruns the first item in the queue.
        rear(): Retruns the last item in the queue.
        size(): Returns the size of the queue.
        isEmpty(): Returns true if queue is empty, false otherwise.
        
 */
var Queue = function (size) {
    this.elements = [size];
    this.front = 0;
    this.rear = -1;
}
Queue.prototype.EnQueue = function (val) {
    this.rear++;
    this.elements[this.rear] = val;
}
Queue.prototype.Peek = function () {
    return this.elements[this.front];
}
Queue.prototype.DeQueue = function () {
    this.elements.shift();
}
Queue.prototype.isEmpty = function () {
    if (this.rear === this.elements.length)
        return true;
    else
        return false;
}
Queue.prototype.isFull = function () {
    if (this.rear + 1 === this.elements.length)
        return true;
    else
        return false;
}
Queue.prototype.getFrontItem = function () {
    return this.elements[this.front];
}
Queue.prototype.getRearItem = function () {
    return this.elements[this.rear];
}

var myQueue = new Queue(4);
myQueue.EnQueue(1);
myQueue.EnQueue(2);
myQueue.EnQueue(3);
myQueue.EnQueue(4);
console.log(`isFull : ${myQueue.isFull()}`);
console.log(` getFrontItem ${myQueue.getFrontItem()}`);
console.log(` Peek ${myQueue.Peek()}`);
console.log(`isEmpty : ${myQueue.isEmpty()}`);
myQueue.DeQueue();
myQueue.DeQueue();
console.log(` Peek ${myQueue.Peek()}`);
myQueue.DeQueue();
myQueue.DeQueue();