using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class MinHeap
    {
        private int[] heap;
        private int size;
        private int capacity;

        public MinHeap(int capacity)
        {
            this.capacity = capacity;
            this.size = 0;
            this.heap = new int[capacity];
        }

        // Вспомогательная функция для обмена элементов в куче
        private void Swap(int idx1, int idx2)
        {
            int temp = heap[idx1];
            heap[idx1] = heap[idx2];
            heap[idx2] = temp;
        }

        // Вспомогательная функция для восстановления свойств кучи вверх по дереву
        private void HeapifyUp(int index)
        {
            int parent = (index - 1) / 2;
            if (index > 0 && heap[index] < heap[parent])
            {
                Swap(index, parent);
                HeapifyUp(parent);
            }
        }

        // Вспомогательная функция для восстановления свойств кучи вниз по дереву
        private void HeapifyDown(int index)
        {
            int leftChild = 2 * index + 1;
            int rightChild = 2 * index + 2;
            int smallest = index;

            if (leftChild < size && heap[leftChild] < heap[smallest])
            {
                smallest = leftChild;
            }

            if (rightChild < size && heap[rightChild] < heap[smallest])
            {
                smallest = rightChild;
            }

            if (smallest != index)
            {
                Swap(index, smallest);
                HeapifyDown(smallest);
            }
        }

        // Добавление элемента в кучу
        public void Insert(int value)
        {
            if (size >= capacity)
            {
                Console.WriteLine("Куча переполнена. Невозможно добавить элемент.");
                return;
            }

            heap[size] = value;
            size++;
            HeapifyUp(size - 1);
        }

        // Удаление корневого элемента (минимального)
        public int RemoveMin()
        {
            if (size <= 0)
            {
                Console.WriteLine("Куча пуста. Невозможно удалить минимальный элемент.");
                return -1; // Возвращаем значение по умолчанию
            }

            int min = heap[0];
            heap[0] = heap[size - 1];
            size--;
            HeapifyDown(0);
            return min;
        }

        // Просмотр корневого элемента (минимального)
        public int PeekMin()
        {
            if (size <= 0)
            {
                Console.WriteLine("Куча пуста. Невозможно просмотреть минимальный элемент.");
                return -1; // Возвращаем значение по умолчанию
            }

            return heap[0];
        }

        public void PrintHeap()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(heap[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
