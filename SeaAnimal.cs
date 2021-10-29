using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
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
        public SeaAnimal(string name, string sound, string diet, int hours, int fins) : base(name, sound, diet, hours)
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

}
