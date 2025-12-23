using System;

namespace RangeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тестирование класса Range\n");

            Range r1 = new Range(1, 5);
            Range r2 = new Range(3, 8);
            Console.WriteLine($"Отрезок 1: {r1}");
            Console.WriteLine($"Отрезок 2: {r2}");

            Console.WriteLine($"\nДлина отрезка 1: {r1.Length}");
            Console.WriteLine($"Длина отрезка 2: {r2.Length}");
            Console.WriteLine($"\nНачало отрезка 1: {r1.Start}");
            r1.Start = 2;
            Console.WriteLine($"После изменения начала на 2: {r1}");
            Console.WriteLine($"\nКонец отрезка 2: {r2.End}");
            r2.End = 10;
            Console.WriteLine($"После изменения конца на 10: {r2}");


            r1 = new Range(1, 5);
            r2 = new Range(3, 8);
            Console.WriteLine("\n--- Операции ---");


            try
            {
                Range union = r1 + r2;
                Console.WriteLine($"Объединение r1 и r2: {union}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Ошибка объединения: {ex.Message}");
            }


            Range intersection = r1 - r2;
            Console.WriteLine($"Пересечение r1 и r2: {intersection}");


            Console.WriteLine("\n--- Сравнение ---");
            Range r3 = new Range(0, 4); // длина = 4 как у r1
            bool areEqual = r1.Equals(r3);
            Console.WriteLine($"Длина r1 ({r1.Length}) равна длине r3 ({r3.Length})? -> {areEqual}");
            bool areEqual2 = r1.Equals(r2);
            Console.WriteLine($"Длина r1 ({r1.Length}) равна длине r2 ({r2.Length})? -> {areEqual2}");


            Console.WriteLine("\n--- Тест с непересекающимися отрезками ---");
            Range r4 = new Range(10, 15);
            Console.WriteLine($"Новый отрезок r4: {r4}");

            try
            {
                Range badUnion = r1 + r4;
                Console.WriteLine($"Объединение r1 и r4: {badUnion}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Range noIntersection = r1 - r4;
            Console.WriteLine($"Пересечение r1 и r4: {noIntersection}");

            Console.ReadKey();
        }
    }
}