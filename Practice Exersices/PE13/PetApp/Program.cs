using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    // Author: Max Lama
    // Class: Program
    // Purpose: Pet simulation
    // Restrictions: None
    internal class Program
    {
        // Method: Main
        // Purpose: Create list of pets and carry out thier actions
        // Restrictions: None
        static void Main(string[] args)
        {
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;

            Pets pets = new Pets();

            Random rand = new Random();

            for(int i = 0; i < 50; i ++)
            {
                // 1 in 10 chance of adding an animal
                if (rand.Next(1, 11) == 1)
                {
                    if (rand.Next(0, 2) == 0)
                    {
                        string sName = "";
                        int nAge;
                        string sLicense = "";
                        // add a dog
                        Console.Write("You bought a dog!!");
                        do
                        {
                            Console.Write("Dog's name => ");
                            sName = Console.ReadLine();
                        } while (sName == "");
                        do
                        {
                            Console.Write("Age => ");
                        } while (!int.TryParse(Console.ReadLine(), out nAge));
                        do
                        {
                            Console.Write("License => ");
                            sLicense = Console.ReadLine();
                        } while (sLicense == "");
                        
                        
                        pets.Add(new Dog(sLicense, sName, nAge));
                    }
                    else
                    {
                        string sName = "";
                        int nAge;
                        // else add a cat
                        Console.WriteLine("You bought a cat!!");
                        do
                        {
                            Console.Write("Cat's name => ");
                            sName = Console.ReadLine();
                        } while (sName == "");
                        do
                        {
                            Console.Write("Age => ");
                        } while (!int.TryParse(Console.ReadLine(), out nAge));

                        pets.Add(new Cat());
                        pets.petList[pets.Count - 1].Name = sName;
                        pets.petList[pets.Count - 1].age = nAge;
                    }
                }
                else
                {
                    // choose a random pet from pets and choose a random activity for the pet to do
                    try
                    {
                        thisPet = pets.petList[rand.Next(0, pets.Count)];
                        
                    } 
                    catch
                    {
                        Console.WriteLine("null");
                        if (thisPet == null) continue;
                    }
                    
                    if (thisPet.GetType() == typeof(Cat))
                    {
                        iCat = (ICat)thisPet;
                        switch (rand.Next(1,6))
                        {
                            case 1:
                                iCat.Eat();
                                break;
                            case 2:
                                iCat.Play();
                                break;
                            case 3:
                                iCat.Purr();
                                break;
                            case 4: 
                                iCat.Scratch();
                                break;
                            case 5:
                                iCat.GotoVet();
                                break;
                        }
                    } 
                    if (thisPet.GetType() == typeof(Dog))
                    {
                        iDog = (IDog)thisPet;
                        switch (rand.Next(1, 6))
                        {
                            case 1:
                                iDog.Eat();
                                break;
                            case 2:
                                iDog.Play();
                                break;
                            case 3:
                                iDog.Bark();
                                break;
                            case 4:
                                iDog.NeedWalk();
                                break;
                            case 5:
                                iDog.GotoVet();
                                break;
                        }
                    }
                }
            }
        }
    }

    // Author: Max Lama
    // Class: Pets
    // Purpose: Parent List of pet objects
    // Restrictions: None
    public class Pets
    {
        public List<Pet> petList = new List<Pet>();

        public int Count
        {
            get
            {
                return petList.Count;
            }
        }

        public void Add(Pet pet)
        {
            petList.Add(pet);
        }

        public void Remove(Pet pet)
        {
            if (pet != null)
            {
                petList.Remove(pet);
            }
        }

        public void RemoveAt(int petEl)
        {
            petList.RemoveAt(petEl);
        }

        public Pet this[int nPetEl]
        {
            get
            {
                Pet returnVal;
                try
                {
                    returnVal = (Pet)petList[nPetEl];
                }
                catch
                {
                    returnVal = null;
                }

                return (returnVal);
            }

            set
            {
                // if the index is less than the number of list elements
                if (nPetEl < petList.Count)
                {
                    // update the existing value at that index
                    petList[nPetEl] = value;
                }
                else
                {
                    // add the value to the list
                    petList.Add(value);
                }
            }
        }

    }

    // Author: Max Lama
    // Class: Pet
    // Purpose: Parent class for all types of pets
    // Restrictions None
    public abstract class Pet
    {
        private string name;
        public int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public abstract void Eat();
        public abstract void Play();
        public abstract void GotoVet();

        public Pet()
        {

        }
        public Pet(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    // Author: Max Lama
    // Interface: IDog
    // Purpose: Interface to Dog class (call methods)
    // Restrictions: None
    public interface IDog
    {
        void Eat();
        void Play();
        void Bark();
        void NeedWalk();
        void GotoVet();
    }

    // Author: Max Lama
    // Interface: ICat
    // Purpose: Interface to Cat class (call methods)
    // Restrictions: None
    public interface ICat
    {
        void Eat();
        void Play();
        void Scratch();
        void Purr();
        void GotoVet();     // This isn't in the YUML doc, but I don't know how to access it otherwise..
    }

    // Author: Max Lama
    // Class: Dog
    // Purpose: Dog type Pet with all of personalized functions
    // Restrictions: None
    public class Dog : Pet, IDog
    {
        public string license;

        public override void Eat()
        {
            Console.WriteLine($"{Name} chomps away on kibble.");
        }

        public override void Play()
        {
            Console.WriteLine($"{Name} runs in circles at the speed of sound.");
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} shouts out a variety of 'woof's 'arf's and 'ruff's.");
        }

        public void NeedWalk()
        {
            Console.WriteLine($"{Name} sits next to the door whining in your direction.");
        }

        public override void GotoVet()
        {
            Console.WriteLine($"{Name} got in a fight with a groundhog and might need a rabies shot.");
        }

        public Dog (string szLicense, string szName, int nAge) : base(szName, nAge)
        {
            license= szLicense;
        }
    }

    // Author: Max Lama
    // Class: Cat
    // Purpose: Cat type Pet with all of personalized functions
    // Restrictions: None
    public class Cat : Pet , ICat
    {
        public override void Eat()
        {
            Console.WriteLine($"{Name} gobbles up the catnip.");
        }

        public override void Play()
        {
            Console.WriteLine($"{Name} chases the reflected light from your phone screen.");
        }

        public void Purr()
        {
            Console.WriteLine($"{Name} purrs happily.");
        }

        public void Scratch()
        {
            Console.WriteLine($"{Name} bears their claws and swipes!");
        }

        public override void GotoVet()
        {
            Console.WriteLine($"{Name} just threw up on the floor, they might be sick :(");
        }

        public Cat () : base()
        {

        }
    }
}
