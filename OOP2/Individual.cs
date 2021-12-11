using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Individual : Customer // Gerçek Müşteri
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNumber { get; set; }
    }
}
