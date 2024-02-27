using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicum24
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Задача 1. 
            // Создаем массив случайных чисел
            int[] randomNumbers = { 5, 8, 3, 10, 5, 7 };

            // Получаем значение первого элемента массива
            int firstElement = randomNumbers[0];

            // Ищем индекс первого вхождения элемента, равного первому элементу
            int index = Array.IndexOf(randomNumbers, firstElement);

            if (index != -1)
            {
                Console.WriteLine($"Элемент {randomNumbers[index]} найден на позиции {index}.");
            }
            else
            {
                Console.WriteLine("Такой элемент не существует в массиве.");
            }
            ///Задача 2
             // Заданный одномерный массив
            int[] arr = { 10, -5, 20, 80, 105, 50, 30, 70, 90, 120 };

            // a) Вывести все неотрицательные элементы
            Console.Write("Неотрицательные элементы: ");
            foreach (int element in arr)
            {
                if (element >= 0)
                    Console.Write(element + " ");
            }
            Console.WriteLine();

            // b) Вывести элементы, не превышающие число 100
            Console.Write("Элементы, не превышающие 100: ");
            foreach (int element in arr)
            {
                if (element <= 100)
                    Console.Write(element + " ");
            }
            Console.WriteLine();

            // c) Вывести четные элементы
            Console.Write("Четные элементы: ");
            foreach (int element in arr)
            {
                if (element % 2 == 0)
                    Console.Write(element + " ");
            }
            Console.WriteLine();
            ///Задача 3. 
             // Заданный одномерный массив
            // Заданный одномерный массив
            int[] myArray = { 5, -3, 4, -8, -9, 1, 9, 6, -3, 4, 8, 2 };

            // Подсчет количества отрицательных элементов
            int negativeCount = 0;
            foreach (int element in myArray)
            {
                if (element < 0)
                    negativeCount++;
            }

            // Вывод результата
            Console.WriteLine($"Количество отрицательных элементов: {negativeCount}");
            ///Задача 4.
           // Заданный одномерный массив
            int[] omas = { 5, -3, 4, -8, -9, 1, 9, 6, -3, 4, 8, 2 };

            // Подсчет количества отрицательных элементов
            foreach (int element in omas)
            {
                if (element < 0)
                    negativeCount++;
            }

            // Вывод результата
            Console.WriteLine($"Количество отрицательных элементов: {negativeCount}");
            ///Задача 5.
              // Заданный одномерный массив
            int[] amas = { 5, -3, 4, -8, -9, 1, 9, 6, -3, 4, 8, 2 };

            // Увеличение всех элементов массива в 5 раз
            for (int i = 0; i < amas.Length; i++)
            {
                amas[i] *= 5;
            }

            // Вывод результата
            Console.WriteLine("Массив после увеличения всех элементов в 5 раз:");
            foreach (int element in amas)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
