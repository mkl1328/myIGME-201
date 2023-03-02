using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE12_q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class MyClass
    {
        private string myString;
        public virtual string GetString()
        {
            return this.myString;
        }

        public string MyString
        {
            set
            {
                this.myString = value;
            }
        }
    }

    public class MyDerivedClass : MyClass
    {
        public override string GetString() 
        {
            return base.GetString() + " (output from the derived class)";
        }
    }
}
