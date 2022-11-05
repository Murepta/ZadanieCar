using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar
{
    public class Car
    {
        public string Name { get; set; }
        public Engine Engine;

        public Car(string name, Engine engine)
        {
            Name = name;
            Engine = engine;
        }

        public void Test()
        {
            StartEngine();
        }
        
        public void StartEngine()
        {
            if (Engine.CountGas == 0)
            {
                throw new CarTestException("Двигатель не работает", DateTime.Now);
            }
            else
            {
                Console.WriteLine("Машина " +Name+ " работает");
            }
        }
    }
}
