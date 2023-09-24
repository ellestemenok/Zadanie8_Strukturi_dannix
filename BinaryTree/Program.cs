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
            Console.Write("Введите количество элементов в куче:");
            int capacity = int.Parse(Console.ReadLine());

            MinHeap minHeap = new MinHeap(capacity);

            Console.Write("Введите элементы кучи:");
            for (int i = 0; i < capacity; i++)
            {
                int value = int.Parse(Console.ReadLine());
                minHeap.Insert(value);
            }

            Console.WriteLine("Минимальный элемент: " + minHeap.PeekMin()); // Выводит "2"

            // Удаление минимального элемента

            int minElement = minHeap.RemoveMin();
            Console.WriteLine("Удален минимальный элемент: " + minElement); // Выводит "2"
            minHeap.PrintHeap();
            Console.WriteLine("Новый минимальный элемент: " + minHeap.PeekMin()); // Выводит "4"

            minHeap.Insert(3); // Вставляем "3"
            minHeap.PrintHeap();
            Console.WriteLine("Новый минимальный элемент: " + minHeap.PeekMin()); // Выводит "4"


            Console.WriteLine("Прямой обход:");
            minHeap.PreOrderTraversal();
            Console.WriteLine();

            Console.WriteLine("Симметричный обход:");
            minHeap.InOrderTraversal();
            Console.WriteLine();

            Console.WriteLine("Обратный обход:");
            minHeap.PostOrderTraversal();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
