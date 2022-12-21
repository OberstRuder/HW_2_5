using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_5
{
    class Airplane : Vehicle, IMaxMass
    {
        public Airplane(int speed, int weight, string info, int maxFlyMass) : base(speed, weight, info)
        {
            MaxFlyMass = maxFlyMass;
            Places = 188;
        }
        public int MaxFlyMass { get; init; }  
        public override void Drive()
        {
            Console.WriteLine("Airplane is flying");
        }

        public override string ToString()
        {
            return base.ToString() + $"\tMaxFlyMass: {MaxFlyMass}";
        }
    }
}
