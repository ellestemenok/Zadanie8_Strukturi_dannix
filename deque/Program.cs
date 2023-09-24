using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Двусторонняя очередь позволяет добавлять и удалять элементы как с начала, так и с конца.
// Сферы применения: алгоритмы обходов графов, реализация структур данных (двусторонний список), оптимизация алгоритмов.
namespace deque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> deque = new LinkedList<string>();

            // Добавление элементов в начало и конец
            deque.AddFirst("Первый");
            deque.AddLast("Второй");
            deque.AddLast("Третий");

            // Извлечение элементов с начала и конца
            string firstItem = deque.First.Value;
            string lastItem = deque.Last.Value;

            Console.WriteLine("Первый элемент: " + firstItem);
            Console.WriteLine("Последний элемент: " + lastItem);
            Console.ReadKey();
        }
    }
}
