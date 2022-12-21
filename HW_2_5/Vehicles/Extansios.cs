using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_5
{
    static class Extansios
    {
        public static void SortedPrint(this IEnumerable<Vehicle> vehicles)
        {
            var sorted = vehicles.OrderBy(ob => ob.Speed).ToArray();
            Array.ForEach(sorted, Console.WriteLine);
        }

        public static void Heavy(this IEnumerable<Vehicle> vehicles)
        {
            var massObj = vehicles.MaxBy(ob => ob.Weight);
            Console.WriteLine($"The heaviest transport: {massObj}");
        }
    }
}
