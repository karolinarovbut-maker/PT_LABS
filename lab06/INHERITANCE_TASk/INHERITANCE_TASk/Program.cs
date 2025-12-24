using System;
using System.Linq;

namespace FileSystemTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Файловая система - Тестирование классов\n");

            // Создаем массив файлов разных типов
            File[] files = new File[10];

            files[0] = new TextFile("Документ1", 2048, new DateTime(2024, 1, 15, 10, 30, 0),
                                   "UTF-8", 50, "Это начало текстового документа...");

            files[1] = new AudioFile("Песня1", 10240000, new DateTime(2023, 12, 20, 14, 15, 0),
                                    new TimeSpan(0, 3, 45), "Исполнитель1", "Альбом1", 320);

            files[2] = new VideoFile("Фильм1", 1500000000, new DateTime(2024, 2, 1, 18, 0, 0),
                                    "1920x1080", new TimeSpan(1, 45, 30), "H.264", 30.0);

            files[3] = new ImageFile("Фото1", 5242880, new DateTime(2024, 3, 10, 12, 30, 0),
                                    "4000x3000", "24-bit", "Canon EOS", new DateTime(2024, 3, 10, 12, 0, 0));

            files[4] = new TextFile("Отчет", 4096, new DateTime(2024, 1, 20, 9, 0, 0),
                                   "Windows-1251", 100, "Годовой отчет компании...");

            files[5] = new AudioFile("Песня2", 8192000, new DateTime(2023, 11, 5, 16, 45, 0),
                                    new TimeSpan(0, 4, 20), "Исполнитель2", "Альбом2", 256);

            files[6] = new VideoFile("Ролик", 500000000, new DateTime(2024, 2, 15, 20, 30, 0),
                                    "1280x720", new TimeSpan(0, 10, 15), "MPEG-4", 25.0);

            files[7] = new ImageFile("Пейзаж", 3145728, new DateTime(2023, 10, 5, 11, 0, 0),
                                    "6000x4000", "32-bit", "Nikon D850", new DateTime(2023, 10, 5, 10, 45, 0));

            files[8] = new TextFile("Заметки", 1024, new DateTime(2024, 3, 1, 8, 15, 0),
                                   "UTF-8", 10, "Список дел на сегодня...");

            files[9] = new AudioFile("Подкаст", 20480000, new DateTime(2024, 1, 25, 21, 0, 0),
                                    new TimeSpan(0, 45, 0), "Ведущий", "Подкаст1", 128);

            // Выводим информацию обо всех файлах
            Console.WriteLine("--- Все файлы в системе ---");
            foreach (var file in files)
            {
                Console.WriteLine();
                file.ShowInfo();
                file.Open();
                file.Close();
                Console.WriteLine(new string('-', 50));
            }

            // 1. Находим суммарный размер всех файлов определенного типа
            Console.WriteLine("\n--- Суммарный размер файлов по типам ---");

            long totalTextSize = files.OfType<TextFile>().Sum(f => f.Size);
            Console.WriteLine($"Суммарный размер текстовых файлов: {totalTextSize} байт");

            long totalAudioSize = files.OfType<AudioFile>().Sum(f => f.Size);
            Console.WriteLine($"Суммарный размер аудио файлов: {totalAudioSize} байт");

            long totalVideoSize = files.OfType<VideoFile>().Sum(f => f.Size);
            Console.WriteLine($"Суммарный размер видео файлов: {totalVideoSize} байт");

            long totalImageSize = files.OfType<ImageFile>().Sum(f => f.Size);
            Console.WriteLine($"Суммарный размер изображений: {totalImageSize} байт");

            // 2. Находим самый старый файл в массиве
            Console.WriteLine("\n--- Самый старый файл ---");
            File oldestFile = files[0];
            foreach (var file in files)
            {
                if (file.CreationDate < oldestFile.CreationDate)
                {
                    oldestFile = file;
                }
            }
            Console.WriteLine($"Самый старый файл: {oldestFile.FileName}");
            Console.WriteLine($"Дата создания: {oldestFile.CreationDate:dd.MM.yyyy HH:mm}");
            Console.WriteLine($"Тип: {oldestFile.GetType().Name}");

            // Дополнительно: показываем специфические методы для каждого типа
            Console.WriteLine("\n--- Специфические операции ---");
            foreach (var file in files)
            {
                Console.WriteLine();
                if (file is TextFile textFile)
                {
                    Console.Write($"Текстовый файл '{textFile.FileName}': ");
                    textFile.Edit();
                }
                else if (file is AudioFile audioFile)
                {
                    Console.Write($"Аудио файл '{audioFile.FileName}': ");
                    audioFile.Play();
                }
                else if (file is VideoFile videoFile)
                {
                    Console.Write($"Видео файл '{videoFile.FileName}': ");
                    videoFile.PlayFullscreen();
                }
                else if (file is ImageFile imageFile)
                {
                    Console.Write($"Изображение '{imageFile.FileName}': ");
                    imageFile.EditImage();
                }
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}