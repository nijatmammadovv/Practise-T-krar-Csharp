using System;
using System.Collections.Generic;
using System.Text;

namespace Practise_Təkrar_Csharp.Models
{
   public class Car
    {
        public string brand;
        public string model;
        public string color;
        public int maxSpeed;

        public Car()
        {
            Console.WriteLine("Car is created!");
        }
        public Car(string brand,string model)
        {
            this.brand = brand;
            this.model = model;
        }
        public Car(string brand,string model,string color,int maxSpeed):this(brand,model)
        {
            this.color = color;
            this.maxSpeed = maxSpeed;
        }
        public virtual string Info()
        {
            return $"Brand ==> {brand}\n" +
                $"Model ==> {model}\n" +
                $"Color ==> {color}\n" +
                $"Maxspeed ==> {maxSpeed}";
        }
    }
}
