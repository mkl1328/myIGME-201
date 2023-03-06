using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE14_q3
{
    // Author: Max Lama
    // Class: Program
    // Purpose: PE14 q3 - classes
    // Restrictions: None
    internal class Program
    {
        // Method: Main
        // Purpose: Create classes and call MyMethod with both
        // Restrictions: None
        static void Main(string[] args)
        {
            Class1 speaker1 = new Class1();
            Class2 speaker2 = new Class2();

            MyMethod(speaker1);
            MyMethod(speaker2);
        }

        // Method: MyMethod
        // Purpose: Call the object's speak() method.
        // Restrictions: None
        public static void MyMethod(object MyObject)
        {
            IMyInterface myInterface = (IMyInterface)MyObject;
            myInterface.speak();
        }
    }

    public interface IMyInterface{
        void speak();
    }

    // Author: Max Lama
    // Class: Class1
    // Purpose: class that has a speak() method.
    // Restrictions: None
    public class Class1: IMyInterface
    {
        public void speak()
        {
            Console.WriteLine("I'm speaking!!");
        }
    }

    // Author: Max Lama
    // Class: Class2
    // Purpose: 2nd class that has a speak() method.
    // Restrictions: None
    public class Class2: IMyInterface
    {
        public void speak()
        {
            Console.WriteLine("AHHHHHHH!!!");
        }
    }
}
