using HW_2_5.Logger;
using System.Security.Cryptography.X509Certificates;

namespace HW_2_5
{
    internal class Adding
    {
        static public void Add()
        {
            Vehicle[] vehicles = new Vehicle[]
            {
                new Bus(AddSpeed(), 10, "Bus"),
                new FamilyCar(10, 10, "FamilyCar"),
                new SportCar(10, 10, "SportCar"),
                new Airplane(10, 10, "Airplan", 10)
            };

            vehicles.SortedPrint();
            Console.WriteLine();
            vehicles.Heavy();
        }

        static private int AddSpeed()
        {
            Console.WriteLine("Enter speed(int)");
            int _result;
            try
            {
                _result = Convert.ToInt32(Console.ReadLine());
            }
            catch (SpeedOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                _result = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {

            }
            finally
            {
                if (_result is ) 
                {
                }
            }
            return _result;
        }
    }
}