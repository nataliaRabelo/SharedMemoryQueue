using SharedQueueManager;

namespace SharedQueueTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating two separate queues
            var queue1 = new SharedMemoryQueue("Queue1");
            var queue2 = new SharedMemoryQueue("Queue2");

            // Enqueueing messages on different queues
            queue1.Enqueue("Message for Queue 1");
            queue2.Enqueue("Message for Queue 2");

            // Dequeueing messages from the queues
            Console.WriteLine(queue1.Dequeue()); // Should print "Message for Queue 1"
            Console.WriteLine(queue2.Dequeue()); // Should print "Message for Queue 2"
        }
    }
}
