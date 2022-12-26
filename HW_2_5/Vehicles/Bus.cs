using HW_2_5.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_5
{
    class Bus : Vehicle
    {
        public Bus(int speed, int weight, string info) : base(speed, weight, info) 
        {
            Places = 45;
        }


        public override void Drive()
        {
            Console.WriteLine("Bus is driving");
        }
    }
}
