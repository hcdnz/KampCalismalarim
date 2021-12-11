using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService // Veri Tabanına Log'lama yapacak başka bir süreç daha tanımladık.
    {
        public void Log()
        {
            Console.WriteLine("Dosya'ya Log'landı!");
        }
    }
}
