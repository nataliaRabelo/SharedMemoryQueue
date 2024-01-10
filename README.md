# 1. SharedQueueManager

SharedQueueManager is a .NET library providing shared memory message queue functionalities. It is designed to facilitate communication and data transfer between different parts of an application or between different applications. This library encapsulates the complexities of shared memory management and provides a straightforward interface for enqueueing and dequeueing messages.

# 2. Features

* Thread-safe message enqueueing and dequeueing.
* Support for variable-sized messages.
* Automatic memory management to prevent leaks.

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
using SharedQueueManager;

// Enqueueing a message
SharedQueueManager.Enqueue("Hello, World!");

// Dequeueing a message
string message = SharedQueueManager.Dequeue();
Console.WriteLine(message);

```