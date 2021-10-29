using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
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
        public LandAnimal(string name, string sound, string diet, int hours, int legs) : base(name, sound, diet, hours)
        {
            _NumLegs = legs;
        }
        // 4 arguments given
        public LandAnimal(string name, string sound, string diet, int hours) : this(name, sound, diet, hours, 4) { }
        #region doesn't work
        //Still broken as fuck - No way of knowing which 2 string 2 int constructor is called
        //public LandAnimal(string sound,string diet,int hours,int legs) : this("No name given",sound, diet, hours, legs) { }
        //public LandAnimal(string name, string diet, int hours, int legs) : this(name, "No sound given", diet, hours, legs) { }
        #endregion

        // 3 arguments given
        public LandAnimal(string name, string sound, string diet) : this(name, sound, diet, 8) { }
        // 2 arguments given
        public LandAnimal(string name, string sound) : this(name, sound, "Generic pellets") { }
        // 1 argument given
        public LandAnimal(string name) : this(name, "Some Sound") { }
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

}
