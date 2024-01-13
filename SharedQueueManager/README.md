# 1. SharedQueueManager

SharedQueueManager is a .NET library providing shared memory message queue functionalities. It is designed to facilitate communication and data transfer between different parts of an application or between different applications. This library encapsulates the complexities of shared memory management and provides a straightforward interface for enqueueing and dequeueing messages.

# 1.1 New Feature: Multiple Queue Management

The latest update introduces the capability to manage multiple shared memory queues, allowing for more flexible and scalable inter-process communication. Users can now create multiple queue instances, each identified by a unique name, and manage them independently within their applications.

# 2. Features

- Thread-safe message enqueueing and dequeueing.
- Support for multiple, distinct shared memory queues.
- Support for variable-sized messages.
- Automatic memory management to prevent leaks.

# 2. Installation

The library can be installed via NuGet:


```
Install-Package SharedQueueManager
```

Or via the .NET CLI:

```
dotnet add package SharedQueueManager
```

# 2. Usage

Here's a basic example of how to use SharedQueueManager to enqueue and dequeue messages:

```
// Initializing two separate queues
var queue1 = new SharedQueueManager.SharedMemoryQueue("Queue1");
var queue2 = new SharedQueueManager.SharedMemoryQueue("Queue2");

// Enqueueing messages into distinct queues
queue1.Enqueue("Message for Queue 1");
queue2.Enqueue("Message for Queue 2");

// Dequeueing messages from the queues
var messageFromQueue1 = queue1.Dequeue();
var messageFromQueue2 = queue2.Dequeue();

```

# Links

[Github Repository](https://github.com/nataliaRabelo/SharedMemoryQueue/tree/master)