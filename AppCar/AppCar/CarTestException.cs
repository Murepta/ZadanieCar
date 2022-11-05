using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar
{
    public class CarTestException: Exception
    {
        public DateTime Date { get; }

        public CarTestException(string message, DateTime date) : base(message)
        {
            Date = date;
        }

    }
}
