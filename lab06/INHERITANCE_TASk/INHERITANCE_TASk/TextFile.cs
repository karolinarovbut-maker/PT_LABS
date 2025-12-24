using System;

namespace FileSystemTask
{
    public class TextFile : File
    {
        public string Encoding { get; set; }
        public int NumberOfLines { get; set; }
        public string ContentPreview { get; set; }

        public TextFile(string fileName, long size, DateTime creationDate,
                       string encoding, int numberOfLines, string contentPreview)
            : base(fileName, size, ".txt", creationDate)
        {
            Encoding = encoding;
            NumberOfLines = numberOfLines;
            ContentPreview = contentPreview;
        }

        public override void Open()
        {
            IsOpen = true;
            Console.WriteLine($"Текстовый файл '{FileName}' открыт в кодировке {Encoding}.");
            Console.WriteLine($"Превью: {ContentPreview}");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Кодировка: {Encoding}");
            Console.WriteLine($"Количество строк: {NumberOfLines}");
        }

        public void Edit()
        {
            Console.WriteLine($"Редактирование текстового файла '{FileName}'...");
        }
    }
}