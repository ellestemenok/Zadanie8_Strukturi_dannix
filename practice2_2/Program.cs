using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice2_2
{
    internal class Program
    {
        static void Main(string[] args) //Отображение символьного массива
        {
            int n = 5;//кол-во элементов в массиве
            string[] a = new string[n];//объявление массива
            string str;//вспомог. переменная
            int i;//вспомог. переменная
            a[0] = "Миссисипи";//элементы массива
            a[1] = "Нил";
            a[2] = "Амазонка";
            a[3] = "Енисей";
            a[4] = "Белая";

            str = "";//даем пустое значение строк переменной

            for (i = 0; i < n; i++)//перебираем элементы и прибавляем их к str
            {
                str += a[i] + "\n";
            }

            Console.WriteLine(str);//вывод на экран результата
            Console.WriteLine("Нажмите любую кнопку!");
            Console.ReadKey();
        }
    }
}
