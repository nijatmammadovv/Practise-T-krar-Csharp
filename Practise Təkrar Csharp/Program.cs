using Practise_Təkrar_Csharp.Models;
using System;

namespace Practise_Təkrar_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car();
            //Car car1 = new Car("Vaz", "Lada", "Black", 200);
            //Console.WriteLine(car1.Info());
            //Console.WriteLine("===================================");
            //Car car2 = new Car("BMW", "Mustang", "Yellow", 240);
            //Console.WriteLine(car2.Info());
            //Console.WriteLine("===================================");
            //Bus bus = new Bus("Daevo", "Electrobus", "Red", 120, 40);
            //Console.WriteLine(bus.Info());
            ////Console.WriteLine(bus.brand+" "+bus.model+ " " +bus.color+ " " +bus.maxSpeed+ " " +bus.passengerCount);
            Console.WriteLine("======================================================================");
            Person person = new Person("Nicat", "Mammadov", 19, false);
            person.ShowInfo();
            Console.WriteLine("======================================================================");
            Student student = new Student("Bakalavr", true, "Nijat", "Mammadov", 19, true);
            student.ShowInfo();
        }
    }
}
