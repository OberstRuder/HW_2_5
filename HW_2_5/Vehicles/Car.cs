using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_5
{
    abstract class Car : Vehicle
    {
        protected Car(int speed, int weigt, string info) : base(speed, weigt, info)
        { 
        }

        public override void Drive()
        {
        }
    }
}
