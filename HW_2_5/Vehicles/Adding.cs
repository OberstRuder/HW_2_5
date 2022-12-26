using HW_2_5.Logger;
using System.Security.Cryptography.X509Certificates;
using static HW_2_5.Logger.SpeedOutOfRangeException;

namespace HW_2_5
{
    internal class Adding
    {
        private ILogger _logger;
        public Adding( ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            Vehicle[] vehicles = new Vehicle[]
            {
                new Bus(AddSpeed(), AddWeight(), "Bus"),
                new FamilyCar(AddSpeed(), AddWeight(), "FamilyCar"),
                new SportCar(AddSpeed(), AddWeight(), "SportCar"),
                new Airplane(AddSpeed(), AddWeight(), "Airplan", 999999)
            };
            _logger.CreateLog("Add vehicles", "Info");
            vehicles.SortedPrint();
            Console.WriteLine();
            vehicles.Heavy();
            _logger.ShowLog();
        }

        static private int AddSpeed()
        {
            Console.WriteLine();
            int _result = 0;
            while (true)
            {
                Console.WriteLine("Enter speed(km/h)");
                
                try
                {
                    _result = Convert.ToInt32(Console.ReadLine());
                    if (_result < 40 || _result > 900) throw new SpeedOutOfRangeException();
                    break;
                }
                catch (SpeedOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return _result;
        }
        static private int AddWeight()
        {
            int _result = 0;
            while (true)
            {
                Console.WriteLine("Enter weight(kg)");

                try
                {
                    _result = Convert.ToInt32(Console.ReadLine());
                    if (_result < 900 || _result > 100000) throw new WeightOutOfRangeException();
                    break;
                }
                catch (SpeedOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return _result;
        }

    }
}