
namespace BookLibraryApp
{
    // Класс Book для представления объекта книги
    public class Book
    {
        // Приватные поля для хранения данных книги
        private string _title;
        private string _author;
        private int _publicationYear;
        private int _pageCount;

        // Свойство Title с валидацией
        public string Title
        {
            // Возвращает значение поля _title
            get { return _title; }
            // Устанавливает значение поля _title с валидацией
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Ошибка: Название книги не может быть пустым!");
                }
                _title = value;
            }
        }

        // Свойство Author с валидацией
        public string Author
        {
            get { return _author; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Ошибка: Автор не может быть пустым!");
                }
                _author = value;
            }
        }
        public int PublicationYear
        {
            get { return _publicationYear; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Ошибка: Год издания должен быть больше 0! Указано: {value}");
                }
                if (value > DateTime.Now.Year)
                {
                    throw new ArgumentException($"Ошибка: Год издания не может быть больше текущего года ({DateTime.Now.Year})! Указано: {value}");
                }
                _publicationYear = value;
            }
        }
        public int PageCount
        {
            get { return _pageCount; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Ошибка: Количество страниц должно быть больше 0! Указано: {value}");
                }
                _pageCount = value;
            }
        }

        public Book(string title, string author, int publicationYear, int pageCount)
        {
            // Устанавливаем свойства через сеттеры
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            PageCount = pageCount;
        }

        public bool IsAntique()
        {
            int currentYear = DateTime.Now.Year;
            int bookAge = currentYear - PublicationYear;
            return bookAge > 50;
        }

        // Метод для вывода информации о книге в читаемом виде
        public void PrintBookInfo()
        {
            // Разделительная линия
            Console.WriteLine(new string('=', 50));
            // Выводим название книги
            Console.WriteLine($"КНИГА: {Title}");
            // Разделительная линия
            Console.WriteLine(new string('-', 50));
            // Выводим автора книги
            Console.WriteLine($"Автор: {Author}");
            // Выводим год издания книги
            Console.WriteLine($"Год издания: {PublicationYear}");
            // Выводим количество страниц в книге
            Console.WriteLine($"Количество страниц: {PageCount}");
            // Выводим статус книги: антикварная или современная
            Console.WriteLine($"Статус: {(IsAntique() ? "АНТИКВАРНАЯ (старше 50 лет)" : "Современная книга")}");
            // Выводим разделительную линию из 50 символов '='
            Console.WriteLine(new string('=', 50));
            // Переходим на новую строку для разделения вывода разных книг
            Console.WriteLine();
        }
    }
}
