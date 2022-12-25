using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_5
{
    abstract class Vehicle
    {
        public Vehicle(int speed, int weight, string info)
        {
            Speed = speed;
            Weight = weight;
            Info = info;
        }

        public int Speed { get; set; }
        public int Weight { get; set; }
        public string Info { get; set; }
        public int Places { get; set; }
      

        public virtual void Drive() { }

        public override string ToString()
        {
            return $"VehicleInfo: {Info}\t Speed: {Speed} km/h\t Weight: {Weight}\t Places: {Places}";
        }



    }
}
