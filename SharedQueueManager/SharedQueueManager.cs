using System.Runtime.InteropServices;

namespace SharedQueueManager
{
    public class SharedMemoryQueue
    {
        private string _queueName;

        public SharedMemoryQueue(string queueName)
        {
            _queueName = queueName;
        }

        [DllImport("SharedQueue.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void enqueue(string queueName, string message);

        [DllImport("SharedQueue.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr dequeue(string queueName);

        public void Enqueue(string message)
        {
            enqueue(_queueName, message);
        }

        public string Dequeue()
        {
            var ptr = dequeue(_queueName);
            if (ptr == IntPtr.Zero)
                return null;

            var message = Marshal.PtrToStringAnsi(ptr);
            return message;
        }
    }
}
