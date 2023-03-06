using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{   
    // Interface: IMood
    // Purpose: control mood of people classes
    // Restrictions: None?
    public interface IMood
    {
        string Mood 
        {
            get;
        }
    }

    // Interface: ITakeOrder
    // Purpose: TakeOrder for types of cups
    // Restrictions: None?
    public interface ITakeOrder
    {
        void TakeOrder();
    }

    // Author: Max Lama
    // Class: Waiter
    // Purpose: Waiter blueprint
    // Restrictions: None
    public class Waiter: IMood
    {
        public string name;
        
        public string Mood
        {
            get;
        }

        public void ServeCustomer(HotDrink cup)
        {
            // Serve code here
        }
    }

    // Author: Max Lama
    // Class: Customer
    // Purpose: Customer blueprint
    // Restrictions: None
    public class Customer: IMood
    {
        public string name;
        public string creditCardNumber;

        public string Mood
        {
            get;
        }
    }

    // Author: Max Lama
    // Class: HotDrink
    // Purpose: Parent class for all drinks
    // Restrictions: None
    public abstract class HotDrink
    {
        public bool instant;
        public bool milk;
        private byte sugar;
        public string size;
        public Customer customer;

        public HotDrink() 
        {
            // Default constructor code here
        }

        public HotDrink(string brand)
        {
            // Constructor code here with usage of string brand
        }

        public virtual void AddSugar(byte amount)
        {
            // Add sugar Code
        }

        public abstract void Steam();
    }

    // Author: Max Lama
    // Class: CupOfCoffee
    // Purpose: Coffee blueprint
    // Restrictions: None
    public class CupOfCoffee: HotDrink, ITakeOrder
    {
        public string beanType;

        public CupOfCoffee(string brand): base(brand)
        {
            // Constructor code
        }

        public override void Steam()
        {
            // Steam code
        }

        public void TakeOrder()
        {
            // Take order code
        }
    }

    // Author: Max Lama
    // Class: CupOfTea
    // Purpose: Tea blueprint
    // Restrictions: None
    public class CupOfTea: HotDrink, ITakeOrder
    {
        public string leafType;

        public CupOfTea(bool CustomerIsWealthy)
        {
            // Constructor Code
        }

        public override void Steam()
        {
            // Steam code
        }

        public void TakeOrder()
        {
            // Take order code
        }
    }

    // Author: Max Lama
    // Class: CupOfCocoa
    // Purpose: Cocoa blueprint
    // Restrictions: None
    public class CupOfCocoa: HotDrink, ITakeOrder
    {
        public static int numCups;
        public bool marshmallows;
        private string source;

        public CupOfCocoa() : this(false)
        {
            // Constructo Code??
        }

        public CupOfCocoa(bool marshmallow): base("Expensive Organic Brand")
        {
            // Constructor Code
        }

        public string Source
        {
            set { source = value; }
        }

        public override void Steam()
        {
            // Code
        }

        public override void AddSugar(byte amount)
        {
            // Code
        }

        public void TakeOrder()
        {
            // Code
        }
    }
}
