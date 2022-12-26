
using HW_2_5.Logger;

namespace HW_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adding add = new Adding(new ConsoleLogger(new Actions(), "json"));
            add.Add();
        }
    }
}