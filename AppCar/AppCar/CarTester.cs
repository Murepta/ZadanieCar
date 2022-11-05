using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar
{
    class CarTester
    {
        public void TestCar(Car car)
        {
            try 
            {
             car.Test();
            }
            catch (CarTestException carexp)
            {
                Console.WriteLine("Ошибка теста: " +carexp.Message);
                Console.WriteLine("Дата теста: " + carexp.Date);
                Console.WriteLine("Название двигателя: " + car.Engine.Name);
            }
        }
    }
}
