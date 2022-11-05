using System;

namespace AppCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine1 = new EngineUaz("УМЗ-414",50);
            Car car1 = new Car("Патриот Экспедиционный",engine1);
            CarTester test = new CarTester();
            test.TestCar(car1);

            Console.WriteLine("");
            Engine engine2 = new EngineUaz("ЗМЗ-ПРО", 0);
            Car car2 = new Car("Хантер", engine2);
            test.TestCar(car2);
        }
    }
}
