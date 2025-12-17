using System;

namespace BookLibraryApp
{
    // Основной класс программы
    class Program
    {
        // Главный метод программы - точка входа
        static void Main(string[] args)
        {
            Book book1 = new Book("Война и мир", "Лев Толстой", 1865, 1300);
            Console.WriteLine(book1);

            Book book2 = new Book("Мастер и Маргарита", "Михаил Булгаков", 1966, 528);
            Console.WriteLine(book2);



            Console.WriteLine(book1.IsAntique());
            book1.PrintBookInfo();
            book2.PrintBookInfo();

        }

        // Вспомогательный статический метод для тестирования валидации
        // static означает, что метод принадлежит классу, а не объекту
        static void TestValidation(string testName, string title, string author, int year, int pages)
        {
            // Блок try-catch для обработки исключений при создании книги
            try
            {
                // Пытаемся создать книгу с переданными параметрами
                // Если параметры невалидные, конструктор выбросит исключение
                Book testBook = new Book(title, author, year, pages);
                // Этот код выполнится только если книга успешно создана (что является ошибкой в тесте)
                // Устанавливаем красный цвет для сообщения об ошибке
                Console.ForegroundColor = ConsoleColor.Red;
                // Выводим сообщение о том, что тест не прошел
                Console.WriteLine($"Тест '{testName}': ОШИБКА - книга создана, но не должна была!");
                // Возвращаем белый цвет для основного текста
                Console.ForegroundColor = ConsoleColor.White;
            }
            // Блок catch выполняется, если при создании книги возникло исключение ArgumentException
            catch (ArgumentException ex)
            {
                // Выводим сообщение о том, что тест прошел успешно
                // Исключение было ожидаемым и поймано
                Console.WriteLine($"Тест '{testName}': УСПЕХ - {ex.Message}");
            }
        }
    }
}
