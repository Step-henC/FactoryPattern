using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface IVehicle
    {
         void Drive();
    }
    public class Car : IVehicle
    {
        public Car() { }
        public new void Drive()
        { Console.WriteLine("Building a new car!"); }
    }
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        { }
        public new void Drive()
        {Console.WriteLine("Building a new Motorcycle!"); }
    }
    public class BigRig : IVehicle
    {
        public BigRig() { } 

        public new void Drive()
        { Console.WriteLine("Building a new BigRig!"); }
    }
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle()
        {
            Console.WriteLine("Welcome to the Car Factory! How many Wheels do you want on your new vehicle?");
            int WheelNumb = Convert.ToInt32(Console.ReadLine());
            switch (WheelNumb)
            {
                case 2:
                    return new Motorcycle();
                case 4:
                    return new Car();
                case 6:
                    return new BigRig();
                default:
                    return new Motorcycle();


            }


        }






    }
}
