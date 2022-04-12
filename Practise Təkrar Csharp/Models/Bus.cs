using System;
using System.Collections.Generic;
using System.Text;

namespace Practise_Təkrar_Csharp.Models
{
   public class Bus:Car
    {
        public int passengerCount;

        public Bus(string brand, string model, string color, int maxSpeed,int passengerCount):base()
        {
            this.passengerCount = passengerCount;
        }

        public override string Info()
        {
            return base.Info() + $"PassengerCount ==> {passengerCount}";
        }
    }
}
