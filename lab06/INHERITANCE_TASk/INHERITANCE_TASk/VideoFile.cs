using System;

namespace FileSystemTask
{
    public class VideoFile : File
    {
        public string Resolution { get; set; }
        public TimeSpan Duration { get; set; }
        public string Codec { get; set; }
        public double FrameRate { get; set; }

        public VideoFile(string fileName, long size, DateTime creationDate,
                        string resolution, TimeSpan duration, string codec, double frameRate)
            : base(fileName, size, ".mp4", creationDate)
        {
            Resolution = resolution;
            Duration = duration;
            Codec = codec;
            FrameRate = frameRate;
        }

        public override void Open()
        {
            IsOpen = true;
            Console.WriteLine($"Видео файл '{FileName}' воспроизводится в разрешении {Resolution}...");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Разрешение: {Resolution}");
            Console.WriteLine($"Длительность: {Duration:mm\\:ss}");
            Console.WriteLine($"Кодек: {Codec}");
            Console.WriteLine($"Частота кадров: {FrameRate} fps");
        }

        public void PlayFullscreen()
        {
            Console.WriteLine($"Полноэкранное воспроизведение видео '{FileName}'...");
        }
    }
}