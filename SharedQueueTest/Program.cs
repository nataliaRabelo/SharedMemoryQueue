namespace SharedQueueTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testando o enfileiramento de mensagens
            Console.WriteLine("Enfileirando mensagens...");
            SharedQueueManager.SharedQueueManager.Enqueue("Hello, World!");
            SharedQueueManager.SharedQueueManager.Enqueue("This is a test message.");

            // Testando o desenfileiramento de mensagens
            Console.WriteLine("Desenfileirando mensagens...");
            string message1 = SharedQueueManager.SharedQueueManager.Dequeue();
            Console.WriteLine($"Mensagem recebida: {message1}");

            string message2 = SharedQueueManager.SharedQueueManager.Dequeue();
            Console.WriteLine($"Mensagem recebida: {message2}");

            // Tentando desenfileirar com a fila vazia
            string message3 = SharedQueueManager.SharedQueueManager.Dequeue();
            if (message3 == null)
            {
                Console.WriteLine("Nenhuma mensagem para desenfileirar. Fila vazia.");
            }
        }
    }
}
