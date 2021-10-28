using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    class Animals : IAnimal
    {
        #region Fields
        //Class fields
        private string name = "noname";
        //Interface integration
        private string sound;
        private string diet;
        private int hoursOfSleep;
        #endregion
        #region Props
        //Class properties
        public string _Name { get { return name; } set { name = value; } }
        //Interface integration
        public string _Sound { get { return sound; } set { sound = value; } }
        public string _Diet { get { return diet; } set { diet = value; } }
        public int _HoursOfSleep { get { return hoursOfSleep; } set { hoursOfSleep = value; } }
        #endregion
        #region Constructor
        public Animals(string name,string sound,string diet,int hours)
        {
            _Name = name;
            _Diet = diet;
            _Sound = sound;
            _HoursOfSleep = hours;
        }
        #endregion
        #region Methods
        public void Eat() 
        {
            Console.WriteLine($"{_Name} : I eat {_Diet}");
        }
        public void Sleep()
        {
            Console.WriteLine($"{_Name} : I sleep for {_HoursOfSleep} hours");
        }
        public void Speak()
        {
            Console.WriteLine($"{_Name} : Makes a sound - {_Sound}");
        }
        #endregion

    }
    class LandAnimal : Animals, IWalk
    {
        #region Fields
        //Interface integration
        private int numLegs;
        #endregion
        #region Props
        public int _NumLegs { get { return numLegs; } set { numLegs = value; } }
        #endregion
        #region Constructor
        //5 arguments given
        public LandAnimal(string name, string sound, string diet,int hours, int legs) : base(name,sound,diet,hours)
        {
            _NumLegs = legs;
        }
        // 4 arguments given
        public LandAnimal(string name,string sound,string diet,int hours) : this(name, sound, diet, hours, 4) { }
        #region doesn't work
        //Still broken as fuck - No way of knowing which 2 string 2 int constructor is called
        //public LandAnimal(string sound,string diet,int hours,int legs) : this("No name given",sound, diet, hours, legs) { }
        //public LandAnimal(string name, string diet, int hours, int legs) : this(name, "No sound given", diet, hours, legs) { }
        #endregion

        // 3 arguments given
        public LandAnimal(string name,string sound,string diet) : this(name, sound, diet, 8) { }
        // 2 arguments given
        public LandAnimal(string name,string sound) : this(name,sound,"Generic pellets") { }
        // 1 argument given
        public LandAnimal(string name) : this(name,"Some Sound") { }
        // No argument given
        public LandAnimal() : this("No name Given") { }
        #endregion

        #region Methods
        public void Walk()
        {
            Console.WriteLine($"{_Name} : I can walk with my {_NumLegs} legs");
        }
        #endregion
    }
    class SeaAnimal : Animals, ISwim
    {
        #region Fields
        //Interface integration
        private int numFins; 
        #endregion

        #region Props
        //Interface integration
        public int _NumFins { get { return numFins; } set { numFins = value; } }
        #endregion

        #region Constructor
        public SeaAnimal(string name, string sound, string diet, int hours, int fins) : base(name,sound,diet,hours)
        {
            _NumFins = fins;
        }
        #endregion

        #region Methods
        public void Swim()
        {
            Console.WriteLine($"{_Name} : I can swim with my {_NumFins} fins");
        }
        #endregion
    }
    class AirAnimal : Animals, IFly
    {
        #region Fields
        //Interface integration
        private int numWings;
        #endregion
        #region Props
        //Interface integration
        public int _NumWings { get { return numWings; } set { numWings = value; } }
        #endregion
        #region Constructors
        public AirAnimal(string name,string sound,string diet,int hours, int wings) : base(name,sound,diet,hours)
        {
            _NumWings = wings;
        }
        #endregion
        #region Methods
        public void Fly()
        {
            Console.WriteLine($"{_Name} : I fly with my {_NumWings} wings");
        }
        #endregion
    }

}
