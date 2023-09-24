using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MinHeap minHeap = new MinHeap(10);

            // Добавление элементов
            minHeap.Insert(4);
            minHeap.Insert(9);
            minHeap.Insert(2);
            minHeap.Insert(7);
            minHeap.Insert(5);


            minHeap.PrintHeap();
            Console.WriteLine("Минимальный элемент: " + minHeap.PeekMin()); // Выводит "2"

            // Удаление минимального элемента
            int minElement = minHeap.RemoveMin();
            Console.WriteLine("Удален минимальный элемент: " + minElement); // Выводит "2"
            minHeap.PrintHeap();
            Console.WriteLine("Новый минимальный элемент: " + minHeap.PeekMin()); // Выводит "4"

            minHeap.Insert(3); // Вставляем "3"
            minHeap.PrintHeap();
            Console.WriteLine("Новый минимальный элемент: " + minHeap.PeekMin()); // Выводит "4"

            Console.ReadKey();
        }
    }
}
