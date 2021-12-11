using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService // Veri Tabanına Log'lama yapacak süreç.
    {
        public void Log()
        {
            Console.WriteLine("Veri Tabanına Log'landı!");
        }
    }
}
