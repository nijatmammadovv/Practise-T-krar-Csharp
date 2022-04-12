using System;
using System.Collections.Generic;
using System.Text;

namespace Practise_Təkrar_Csharp.Models
{
   public class Person
    {
        public string Name;
        public string Surname;
        public int Age;
        public bool isMarried;

        public Person()
        {

        }
        public Person(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }
        public Person(string name,string surname,int age,bool ismarried):this(name,surname)
        {
            Age = age;
            isMarried = ismarried;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name ==> {Name}\n" +
                $"Surname ==> {Surname}\n" +
                $"Age ==> {Age}\n" +
                $"Is married ==> {isMarried}");
        }
    }
}
