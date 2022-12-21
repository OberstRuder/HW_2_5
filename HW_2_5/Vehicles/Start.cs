using System.Security.Cryptography.X509Certificates;

namespace HW_2_5
{
    internal class Start
    {
        static public void VehicleStart()
        {
            Vehicle[] vehicles = new Vehicle[]
            {
                new Bus(105, 26000, "Bus1"),
                new Bus(100, 28000, "Bus2"),
                new FamilyCar(140, 1500, "FamilyCar1"),
                new FamilyCar(120, 2100, "FamilyCar2"),
                new SportCar(300, 900, "SportCar1"),
                new SportCar(280, 1100, "SportCar2"),
                new Airplane(1100, 45000, "Airoplan1", 90000),
                new Airplane(360, 250000, "Airoplane2", 550000),
            };

            vehicles.SortedPrint();
            Console.WriteLine();
            vehicles.Heavy();
        }
    }
}