using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_5
{
    class SportCar : Car
    {
        public SportCar(int speed, int weight, string info) : base(speed, weight, info)
        {
            Places = 2;
        }
        
        public override void Drive()
        {
            Console.WriteLine("Sport car is driving");
        }
    }
}
