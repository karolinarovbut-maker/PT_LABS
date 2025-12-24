using System;

namespace FileSystemTask
{
    public class File
    {
        public string FileName { get; set; }
        public long Size { get; set; }
        public string Extension { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsOpen { get; set; }

        public File(string fileName, long size, string extension, DateTime creationDate)
        {
            FileName = fileName;
            Size = size;
            Extension = extension;
            CreationDate = creationDate;
            IsOpen = false;
        }

        public virtual void Open()
        {
            IsOpen = true;
            Console.WriteLine($"Файл '{FileName}' открыт для просмотра.");
        }

        public virtual void Close()
        {
            IsOpen = false;
            Console.WriteLine($"Файл '{FileName}' закрыт.");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Имя: {FileName}");
            Console.WriteLine($"Размер: {Size} байт");
            Console.WriteLine($"Расширение: {Extension}");
            Console.WriteLine($"Дата создания: {CreationDate:dd.MM.yyyy HH:mm}");
            Console.WriteLine($"Открыт: {IsOpen}");
        }
    }
}