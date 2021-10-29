using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
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
        public AirAnimal(string name, string sound, string diet, int hours, int wings) : base(name, sound, diet, hours)
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
