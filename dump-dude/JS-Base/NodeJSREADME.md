## NodeJS Basics

1. callback hell - nodejs by default asynchronous asyc.waterfall/series/parallel
2. Promises - return resolve or reject synchronous
3. async / await -execute code synchronous  way

### npm 
1. Driective Graph Queuel
2. [Streams in Node.js](https://stackabuse.com/introduction-to-node-js-streams/)
The Stream module is a native module that is shipped by default in Node.js. The Stream is an instance of the EventEmitter class, which handles events asynchronously in Node.js. Due to their superclass, streams are inherently event-based.

    There are 4 types of streams in Node.js:
- Writable: Used to write data sequentially
- Readable: Used to read data sequentially
- Duplex: Used to both read and write data sequentially
- Transform: Where data can be modified when writing or reading. Take compression for an example, with a stream like this you can write compressed data and read decompressed data.
- Drain : If a call to stream.write(chunk) returns false, the 'drain' event will be emitted when it is appropriate to resume writing data to the stream.

 **Events in Readable Streams**
data: Emitted when a chunk of data is read from the stream. By default, the chunk will be a Buffer object. If you want to change it you can use the .setEncoding() method.
error: Emitted when an error occurs during reading. This may happen if the writable stream is unable to generate data due to some internal failure or when an invalid chunk is pushed to the stream.
end: Emitted when there is no more data in the stream.
close: Emitted when the stream resource is closed and indicates that no more events will be emitted in the future.
readable: Emitted when the data is available in the readable stream to read.

 **Events in Writable Streams**
close: Emitted when the stream resource is closed and indicates that no more events will be emitted in the future.
error: Emitted when an error occurs during reading. This may happen if the writable stream is unable to generate data due to some internal failure or when invalid chunk data is pushed to the stream.
finish: Emitted when all the data has been flushed from the writable stream.
pipe: Emitted when the writable stream is piped to a readable stream.
unpipe: Emitted when the writable stream is un-piped from a readable stream.

3. [SolidJS](https://stackabuse.com/spread-operator-in-javascript/)
 - Expanding Arrays
 - Combining Arrays
 - Copying Arrays and Objects
 - [Alternative Functions](https://github.com/tusharbudhe0302/OOP/blob/master/JS/design-patters/JSREADME.md)

 4. [Node.js degugging options](https://nodejs.org/dist/latest-v12.x/docs/api/debugger.html)

** Note : -- It's Double dash**
- --force-fips
- --http-parser
- --inspect
- --max-http-header-size
- --napi-modules
- --no-deprecation
- --no-force-async-hooks-checks
- --trace-deprecation
- --trace-tls
- --trace-warnings
- --use-openssl-ca
- --v8-pool-size
- --zero-fill-buffers

5. V8 Engine options: :

- --abort-on-uncaught-exception
- --max-old-space-size
- --perf-basic-prof-only-functions
- --perf-basic-prof
- --perf-prof-unwinding-info
- --perf-prof
- --stack-trace-limit

**Note:**  Do not forget NodeJS is Javascript framework, built on V8 engine of chrome browser.

6. Buffer
-  Buffer class was introduced as part of the Node.js API to enable interaction with octet streams in TCP streams, file system operations, and other contexts
 - from
 - alloc
 - allocUnsafe
 - Buffer Over Come Problem of Event Emitter.Event Emitter will not return callback results.
 - Once Event occured Save it to buffer memory.

 7. EventEmitter
- emitter.eventNames()
- emitter.listenerCount(eventName)
-  emitter.listeners(eventName)
- emitter.removeListener(eventName, listener)
- events.once(emitter, name)
- EventEmitter.defaultMaxListeners.