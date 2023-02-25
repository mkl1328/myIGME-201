using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle;

namespace Traffic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Compact car1 = new Compact(); 
            AddPassenger(ref car1); // Why isn't this working? it's inheriting from IPassengerCarrier
        }

        static void AddPassenger(ref IPassengerCarrier passengerCarrier)
        {
            passengerCarrier.LoadPassenger();
            Console.WriteLine(passengerCarrier.ToString());
        }
    }
}
