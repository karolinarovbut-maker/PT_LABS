using System;

namespace ConsoleApp1

{
    class Program
    {
        static void Main()
        {
            bool exitProgram = false;
            while (!exitProgram)
            {
                Console.Clear();
                Console.WriteLine("=== Лабораторная работа № 3 ===");
                Console.WriteLine("Выберите блок задач:");
                Console.WriteLine("1. Блок 1: Переменные и операторы");
                Console.WriteLine("2. Блок 2: Условные операторы");
                Console.WriteLine("3. Блок 3: Циклы");
                Console.WriteLine("4. Блок 4: Массивы");
                Console.WriteLine("5. Блок 5: Функции");
                Console.WriteLine("0. Выход");
                Console.Write("Ваш выбор: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1": ShowBlock1Menu(); break;
                    case "2": ShowBlock2Menu(); break;
                    case "3": ShowBlock3Menu(); break;
                    case "4": ShowBlock4Menu(); break;
                    case "5": ShowBlock5Menu(); break;
                    case "0": exitProgram = true; break;
                    default:
                        Console.WriteLine("Неверный выбор. Нажмите любую клавишу.");
                        Console.ReadKey();
                        break;
                }
            }
            Console.WriteLine("Выход из программы. До свидания!");
        }

        static void ShowBlock1Menu()
        {
            bool exitBlock = false;
            while (!exitBlock)
            {
                Console.Clear();
                Console.WriteLine("=== Блок 1: Переменные и операторы ===");
                Console.WriteLine("1. ИМТ (Задача 2)");
                Console.WriteLine("2. Перевод времени (Задача 4)");
                Console.WriteLine("3. Цена со скидкой (Задача 6)");
                Console.WriteLine("0. Назад в главное меню");
                Console.Write("Ваш выбор: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": Task1_2(); break;
                    case "2": Task1_4(); break;
                    case "3": Task1_6(); break;
                    case "0": exitBlock = true; break;
                    default:
                        Console.WriteLine("Неверный выбор. Нажмите любую клавишу.");
                        Console.ReadKey();
                        break;
                }

                if (!exitBlock)
                {
                    Console.WriteLine("Нажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                }
            }
        }

        static void ShowBlock2Menu()
        {
            bool exitBlock = false;
            while (!exitBlock)
            {
                Console.Clear();
                Console.WriteLine("=== Блок 2: Условные операторы ===");
                Console.WriteLine("1. Тип треугольника (Задача 2)");
                Console.WriteLine("2. Оценка по числу (Задача 4)");
                Console.WriteLine("3. Конвертация валют (Задача 6)");
                Console.WriteLine("0. Назад в главное меню");
                Console.Write("Ваш выбор: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": Task2_2(); break;
                    case "2": Task2_4(); break;
                    case "3": Task2_6(); break;
                    case "0": exitBlock = true; break;
                    default:
                        Console.WriteLine("Неверный выбор. Нажмите любую клавишу.");
                        Console.ReadKey();
                        break;
                }

                if (!exitBlock)
                {
                    Console.WriteLine("Нажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                }
            }
        }

        static void ShowBlock3Menu()
        {
            bool exitBlock = false;
            while (!exitBlock)
            {
                Console.Clear();
                Console.WriteLine("=== Блок 3: Циклы ===");
                Console.WriteLine("1. Переворот числа (Задача 2)");
                Console.WriteLine("2. Максимальное нечётное число (Задача 4)");
                Console.WriteLine("3. Арифметическая прогрессия (Задача 6)");
                Console.WriteLine("0. Назад в главное меню");
                Console.Write("Ваш выбор: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": Task3_2(); break;
                    case "2": Task3_4(); break;
                    case "3": Task3_6(); break;
                    case "0": exitBlock = true; break;
                    default:
                        Console.WriteLine("Неверный выбор. Нажмите любую клавишу.");
                        Console.ReadKey();
                        break;
                }

                if (!exitBlock)
                {
                    Console.WriteLine("Нажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                }
            }
        }

        static void ShowBlock4Menu()
        {
            bool exitBlock = false;
            while (!exitBlock)
            {
                Console.Clear();
                Console.WriteLine("=== Блок 4: Массивы ===");
                Console.WriteLine("1. Второй по величине элемент (Задача 2)");
                Console.WriteLine("2. Чётные элементы в столбцах (Задача 4)");
                Console.WriteLine("3. Диагонали матрицы (Задача 6)");
                Console.WriteLine("0. Назад в главное меню");
                Console.Write("Ваш выбор: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": Task4_2(); break;
                    case "2": Task4_4(); break;
                    case "3": Task4_6(); break;
                    case "0": exitBlock = true; break;
                    default:
                        Console.WriteLine("Неверный выбор. Нажмите любую клавишу.");
                        Console.ReadKey();
                        break;
                }

                if (!exitBlock)
                {
                    Console.WriteLine("Нажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                }
            }
        }

        static void ShowBlock5Menu()
        {
            bool exitBlock = false;
            while (!exitBlock)
            {
                Console.Clear();
                Console.WriteLine("=== Блок 5: Функции ===");
                Console.WriteLine("1. Генерация массива (Задача 2)");
                Console.WriteLine("2. Сумма цифр числа (рекурсия) (Задача 4)");
                Console.WriteLine("3. Разделение числа (Задача 6)");
                Console.WriteLine("4. Длины строк (Задача 8)");
                Console.WriteLine("0. Назад в главное меню");
                Console.Write("Ваш выбор: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": Task5_2(); break;
                    case "2": Task5_4(); break;
                    case "3": Task5_6(); break;
                    case "4": Task5_8(); break;
                    case "0": exitBlock = true; break;
                    default:
                        Console.WriteLine("Неверный выбор. Нажмите любую клавишу.");
                        Console.ReadKey();
                        break;
                }

                if (!exitBlock)
                {
                    Console.WriteLine("Нажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                }
            }
        }

        // =============== Блок 1 ===============
        static void Task1_2()
        {
            Console.Write("Введите рост (в см): ");
            if (!double.TryParse(Console.ReadLine(), out double height) || height <= 0)
            {
                Console.WriteLine("Некорректный рост.");
                return;
            }

            Console.Write("Введите вес (в кг): ");
            if (!double.TryParse(Console.ReadLine(), out double weight) || weight <= 0)
            {
                Console.WriteLine("Некорректный вес.");
                return;
            }

            double imt = weight / Math.Pow(height / 100.0, 2);
            Console.WriteLine($"ИМТ = {imt:F1}");
        }

        static void Task1_4()
        {
            Console.Write("Введите количество секунд: ");
            if (!int.TryParse(Console.ReadLine(), out int seconds) || seconds < 0)
            {
                Console.WriteLine("Некорректное количество секунд.");
                return;
            }

            int hours = seconds / 3600;
            int minutes = (seconds % 3600) / 60;
            int secs = seconds % 60;
            Console.WriteLine($"{hours:D2}:{minutes:D2}:{secs:D2}");
        }

        static void Task1_6()
        {
            Console.Write("Введите первоначальную цену товара (в рублях): ");
            if (!double.TryParse(Console.ReadLine(), out double originalPrice) || originalPrice < 0)
            {
                Console.WriteLine("Некорректная цена.");
                return;
            }

            Console.Write("Введите размер скидки (%): ");
            if (!double.TryParse(Console.ReadLine(), out double discountPercent) || discountPercent < 0 || discountPercent > 100)
            {
                Console.WriteLine("Скидка должна быть от 0 до 100%.");
                return;
            }

            double finalPrice = originalPrice * (1 - discountPercent / 100.0);
            Console.WriteLine($"Итоговая цена: {finalPrice:F2} руб.");
        }

        // =============== Блок 2 ===============
        static void Task2_2()
        {
            Console.Write("Введите длину стороны A: ");
            if (!double.TryParse(Console.ReadLine(), out double a) || a <= 0) { Console.WriteLine("Некорректная сторона."); return; }
            Console.Write("Введите длину стороны B: ");
            if (!double.TryParse(Console.ReadLine(), out double b) || b <= 0) { Console.WriteLine("Некорректная сторона."); return; }
            Console.Write("Введите длину стороны C: ");
            if (!double.TryParse(Console.ReadLine(), out double c) || c <= 0) { Console.WriteLine("Некорректная сторона."); return; }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("Такой треугольник не существует.");
                return;
            }

            if (a == b && b == c)
                Console.WriteLine("Треугольник равносторонний.");
            else if (a == b || b == c || a == c)
                Console.WriteLine("Треугольник равнобедренный.");
            else
                Console.WriteLine("Треугольник разносторонний.");
        }

        static void Task2_4()
        {
            Console.Write("Введите оценку (целое число от 1 до 5): ");
            if (int.TryParse(Console.ReadLine(), out int grade))
            {
                switch (grade)
                {
                    case 1: Console.WriteLine("Плохо"); break;
                    case 2: Console.WriteLine("Неудовлетворительно"); break;
                    case 3: Console.WriteLine("Удовлетворительно"); break;
                    case 4: Console.WriteLine("Хорошо"); break;
                    case 5: Console.WriteLine("Отлично"); break;
                    default: Console.WriteLine("Ошибка: оценка должна быть от 1 до 5."); break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }
        }

        static void Task2_6()
        {
            const double USD_RATE = 0.011;
            const double EUR_RATE = 0.010;
            const double GBP_RATE = 0.0085;

            Console.Write("Введите сумму в рублях: ");
            if (!double.TryParse(Console.ReadLine(), out double rubles) || rubles < 0)
            {
                Console.WriteLine("Некорректная сумма.");
                return;
            }

            Console.WriteLine("Выберите валюту:");
            Console.WriteLine("1 — Доллар США (USD)");
            Console.WriteLine("2 — Евро (EUR)");
            Console.WriteLine("3 — Британский фунт (GBP)");
            Console.Write("Ваш выбор (1/2/3): ");
            string choice = Console.ReadLine();

            double result = 0;
            string currency = "";
            switch (choice)
            {
                case "1": result = rubles * USD_RATE; currency = "USD"; break;
                case "2": result = rubles * EUR_RATE; currency = "EUR"; break;
                case "3": result = rubles * GBP_RATE; currency = "GBP"; break;
                default: Console.WriteLine("Неверный выбор валюты."); return;
            }

            Console.WriteLine($"{rubles:F2} рублей = {result:F2} {currency}");
        }

        // =============== Блок 3 ===============
        static void Task3_2()
        {
            Console.Write("Введите целое число: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Введено не целое число.");
                return;
            }

            bool isNegative = number < 0;
            number = Math.Abs(number);
            int reversed = 0;

            while (number > 0)
            {
                reversed = reversed * 10 + number % 10;
                number /= 10;
            }

            if (isNegative) reversed = -reversed;
            Console.WriteLine($"Перевернутое число: {reversed}");
        }

        static void Task3_4()
        {
            Console.Write("Введите число a: ");
            if (!int.TryParse(Console.ReadLine(), out int a)) { Console.WriteLine("Некорректный ввод."); return; }
            Console.Write("Введите число b: ");
            if (!int.TryParse(Console.ReadLine(), out int b)) { Console.WriteLine("Некорректный ввод."); return; }

            if (a > b) (a, b) = (b, a); // swap

            int maxOdd = -1;
            for (int i = b; i >= a; i--)
            {
                if (i % 2 != 0)
                {
                    maxOdd = i;
                    break;
                }
            }

            if (maxOdd == -1)
                Console.WriteLine("В диапазоне нет нечётных чисел.");
            else
                Console.WriteLine($"Максимальное нечётное число: {maxOdd}");
        }

        static void Task3_6()
        {
            Console.Write("Введите количество членов (n): ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0) { Console.WriteLine("n должно быть > 0."); return; }
            Console.Write("Первый член: ");
            if (!double.TryParse(Console.ReadLine(), out double first)) { Console.WriteLine("Некорректный ввод."); return; }
            Console.Write("Шаг: ");
            if (!double.TryParse(Console.ReadLine(), out double step)) { Console.WriteLine("Некорректный ввод."); return; }

            double sum = 0;
            Console.Write("Члены прогрессии: ");
            for (int i = 0; i < n; i++)
            {
                double term = first + i * step;
                Console.Write($"{term}{(i < n - 1 ? ", " : "")}");
                sum += term;
            }
            Console.WriteLine($"\nСумма: {sum}");
        }

        // =============== Блок 4 ===============
        static void Task4_2()
        {
            Console.Write("Введите размер массива: ");
            if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
            {
                Console.WriteLine("Размер должен быть > 0.");
                return;
            }

            int[] arr = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
                arr[i] = rand.Next(1, 101);

            Console.WriteLine("Массив:");
            for (int i = 0; i < size; i++)
                Console.WriteLine($"[{i}] = {arr[i]}");

            int max = arr[0], secondMax = int.MinValue;
            foreach (int num in arr)
            {
                if (num > max) max = num;
            }

            foreach (int num in arr)
            {
                if (num < max && num > secondMax)
                    secondMax = num;
            }

            if (secondMax == int.MinValue)
                Console.WriteLine("Второго по величине элемента нет.");
            else
            {
                int index = Array.IndexOf(arr, secondMax);
                Console.WriteLine($"Второй по величине: {secondMax}, индекс: {index}");
            }
        }

        static void Task4_4()
        {

            Console.Write("Строки: ");
            if (!int.TryParse(Console.ReadLine(), out int rows) || rows <= 0)
            {
                Console.WriteLine("Некорректно.");
                return;
            }
            Console.Write("Столбцы: ");
            if (!int.TryParse(Console.ReadLine(), out int cols) || cols <= 0)
            {
                Console.WriteLine("Некорректно.");
                return;
            }

            int[,] mat = new int[rows, cols];
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    mat[i, j] = rand.Next(1, 101);

            Console.WriteLine("Матрица:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    Console.Write(mat[i, j] + "\t");
                Console.WriteLine();
            }

            // Шаг 1: посчитать количество чётных в каждом столбце и найти максимум
            int[] evenCounts = new int[cols]; // массив для хранения количества чётных в каждом столбце
            int maxEvenCount = -1;

            for (int j = 0; j < cols; j++)
            {
                int even = 0;
                for (int i = 0; i < rows; i++)
                {
                    if (mat[i, j] % 2 == 0)
                        even++;
                }
                evenCounts[j] = even;
                Console.WriteLine($"Столбец {j + 1}: {even} чётных");
                if (even > maxEvenCount)
                    maxEvenCount = even;
            }

            // Шаг 2: найти все столбцы с количеством чётных = maxEvenCount
            Console.Write($"Столбец(ы) с максимальным количеством чётных ({maxEvenCount}): ");
            bool first = true;
            for (int j = 0; j < cols; j++)
            {
                if (evenCounts[j] == maxEvenCount)
                {
                    if (!first) Console.Write(", ");
                    Console.Write(j + 1); // нумерация с 1
                    first = false;
                }
            }
            Console.WriteLine();

        }

        static void Task4_6()
        {
            Console.Write("Размер квадратной матрицы: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0) { Console.WriteLine("Некорректный размер."); return; }

            int[,] mat = new int[n, n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    mat[i, j] = rand.Next(1, 101);

            Console.WriteLine("Матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(mat[i, j] + "\t");
                Console.WriteLine();
            }

            int maxMain = mat[0, 0];
            for (int i = 1; i < n; i++)
                if (mat[i, i] > maxMain) maxMain = mat[i, i];

            int maxSec = mat[0, n - 1];
            for (int i = 1; i < n; i++)
                if (mat[i, n - 1 - i] > maxSec) maxSec = mat[i, n - 1 - i];

            Console.WriteLine($"Макс. на главной: {maxMain}");
            Console.WriteLine($"Макс. на побочной: {maxSec}");
            Console.WriteLine($"Сумма: {maxMain + maxSec}");
        }

        // =============== Блок 5 ===============
        static void Task5_2()
        {
            int[] arr = GenerateArray(10, 1, 100);
            Console.WriteLine("Сгенерированный массив:");
            foreach (int x in arr) Console.Write(x + " ");
            Console.WriteLine();
        }

        static int[] GenerateArray(int count, int min, int max)
        {
            Random rand = new Random();
            int[] arr = new int[count];
            for (int i = 0; i < count; i++)
                arr[i] = rand.Next(min, max + 1);
            return arr;
        }

        static void Task5_4()
        {
            Console.Write("Введите целое число: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int sum = DigitSum(Math.Abs(n));
                Console.WriteLine($"Сумма цифр: {sum}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }
        }

        static int DigitSum(int n)
        {
            return n == 0 ? 0 : n % 10 + DigitSum(n / 10);
        }

        static void Task5_6()
        {
            Console.Write("Введите число (например, 123.456): ");
            if (double.TryParse(Console.ReadLine(), out double num))
            {
                Split(num, out int whole, out double frac);
                Console.WriteLine($"Число: {num}");
                Console.WriteLine($"Целая часть: {whole}");
                Console.WriteLine($"Дробная часть: {frac:F6}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }
        }

        static void Split(double number, out int whole, out double fraction)
        {
            whole = (int)Math.Truncate(number);
            fraction = number - whole;
        }

        static void Task5_8()
        {
            int[] lengths = GetLengths("My", "Name", "Is", "Jabbar", "I", "Live", "In", "Qatar");
            Console.WriteLine("Длины строк:");
            foreach (int len in lengths) Console.Write(len + " ");
            Console.WriteLine();
        }

        static int[] GetLengths(params string[] strings)
        {
            int[] result = new int[strings.Length];
            for (int i = 0; i < strings.Length; i++)
                result[i] = strings[i].Length;
            return result;
        }
    }
}
