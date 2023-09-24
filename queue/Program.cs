using System;
using System.Collections.Generic;


// Очередь представляет собой структуру данных "первый пришел - первый вышел" (First-In-First-Out, FIFO).
// Сферы применения: управление задачами, очереди обработки событий, буферизация.
namespace queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            // Добавление элементов в очередь
            queue.Enqueue("Первый");
            queue.Enqueue("Второй");
            queue.Enqueue("Третий");

            // Извлечение элементов из очереди
            while (queue.Count > 0)
            {
                string item = queue.Dequeue();
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}