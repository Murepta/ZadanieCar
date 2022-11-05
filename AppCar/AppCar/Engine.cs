using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar
{
    abstract public class Engine
    {
        public string Name { get; set; }
        int count;
        public int CountGas
        {
            get
            {
                return count;
            }
            protected set
            {
                if (value < 0)
                {
                    count = 0;
                }
                else
                {
                    count = value;
                }
            }
        }

        public Engine(string name, int countgas)
        {
            Name = name;
            CountGas = countgas;
        }
    }
}
