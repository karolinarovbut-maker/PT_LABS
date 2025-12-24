using System;

namespace FileSystemTask
{
    public class ImageFile : File
    {
        public string Resolution { get; set; }
        public string ColorDepth { get; set; }
        public string CameraModel { get; set; }
        public DateTime CaptureDate { get; set; }

        public ImageFile(string fileName, long size, DateTime creationDate,
                        string resolution, string colorDepth, string cameraModel, DateTime captureDate)
            : base(fileName, size, ".jpg", creationDate)
        {
            Resolution = resolution;
            ColorDepth = colorDepth;
            CameraModel = cameraModel;
            CaptureDate = captureDate;
        }

        public override void Open()
        {
            IsOpen = true;
            Console.WriteLine($"Изображение '{FileName}' открыто в просмотрщике.");
            Console.WriteLine($"Разрешение: {Resolution}");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Разрешение: {Resolution}");
            Console.WriteLine($"Глубина цвета: {ColorDepth}");
            Console.WriteLine($"Камера: {CameraModel}");
            Console.WriteLine($"Дата съемки: {CaptureDate:dd.MM.yyyy}");
        }

        public void EditImage()
        {
            Console.WriteLine($"Редактирование изображения '{FileName}'...");
        }
    }
}