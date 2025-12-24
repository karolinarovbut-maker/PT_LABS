using System;

namespace FileSystemTask
{
    public class AudioFile : File
    {
        public TimeSpan Duration { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public int Bitrate { get; set; }

        public AudioFile(string fileName, long size, DateTime creationDate,
                        TimeSpan duration, string artist, string album, int bitrate)
            : base(fileName, size, ".mp3", creationDate)
        {
            Duration = duration;
            Artist = artist;
            Album = album;
            Bitrate = bitrate;
        }

        public override void Open()
        {
            IsOpen = true;
            Console.WriteLine($"Аудио файл '{FileName}' воспроизводится...");
            Console.WriteLine($"Исполнитель: {Artist}, Альбом: {Album}");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Длительность: {Duration:mm\\:ss}");
            Console.WriteLine($"Исполнитель: {Artist}");
            Console.WriteLine($"Альбом: {Album}");
            Console.WriteLine($"Битрейт: {Bitrate} kbps");
        }

        public void Play()
        {
            Console.WriteLine($"Воспроизведение аудио файла '{FileName}'...");
        }
    }
}