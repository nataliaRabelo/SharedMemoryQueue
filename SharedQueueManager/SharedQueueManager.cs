using System.Runtime.InteropServices;

namespace SharedQueueManager
{
    public static class SharedQueueManager
    {
        [DllImport("libs/SharedQueue.dll")]
        private static extern void enqueue(string message);

        [DllImport("libs/SharedQueue.dll")]
        private static extern IntPtr dequeue();

        [DllImport("libs/SharedQueue.dll")]
        private static extern void free_memory(IntPtr ptr);

        public static void Enqueue(string message)
        {
            enqueue(message);
        }

        public static string Dequeue()
        {
            var ptr = dequeue();
            if (ptr == IntPtr.Zero)
                return null;

            var message = Marshal.PtrToStringAnsi(ptr);
            free_memory(ptr);
            return message;
        }
    }
}
