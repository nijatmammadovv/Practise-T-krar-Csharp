using System;
using System.Collections.Generic;
using System.Text;

namespace Practise_Təkrar_Csharp.Models
{
    public class Student:Person
    {
        public string Degree;
        public bool isHigh;

        public Student(string degree,bool ishigh, string name, string surname, int age, bool ismarried):base(name,surname,age,ismarried)
        {
            Degree = degree;
            isHigh = ishigh;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Degree ==> {Degree}\n" +
                $"Is high ==> {isHigh}");
        }
    }
}
