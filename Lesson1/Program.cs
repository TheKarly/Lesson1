using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько вам лет?");
            string bas;//*объявление переменной строкового типа
            bas = Console.ReadLine();//инициализация переменной (присвоение значения)
            int age;//*объявление переменной целочисленного типа
            age = int.Parse(bas);
            if (age >= 18) //если что-то
            {
                Console.WriteLine("Вы взрослый");
            }
            else
            {
                Console.WriteLine("Вы король");
            }
        }
    }
}
