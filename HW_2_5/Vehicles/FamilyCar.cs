using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_5
{
    class FamilyCar : Car
    {
        public FamilyCar(int speed, int weight, string info) : base(speed, weight, info) 
        {
            Places = 5;

        }
        public override void Drive()
        {
            Console.WriteLine("Family car is driving");
        }
    }
}
