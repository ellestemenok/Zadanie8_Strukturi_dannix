using System;
using System.Collections;

// Хэш-таблица - это структура данных, которая хранит пары ключ-значение и обеспечивает быстрый доступ к значениям по ключу.
// Сферы применения: хранение данных с быстрым доступом, реализация баз данных, оптимизация поиска.
namespace hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();

            // Добавление пар ключ-значение
            hashtable["Ключ1"] = "Значение1";
            hashtable["Ключ2"] = "Значение2";
            hashtable["Ключ3"] = "Значение3";

            // Получение значения по ключу
            string value = (string)hashtable["Ключ2"];
            Console.WriteLine("Значение по ключу 'Ключ2': " + value);
            Console.ReadKey();
        }
    }
}