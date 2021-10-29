using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    class Animals : IAnimal
    {
        #region Delegate and events
        public delegate void AnimalSleepEventHandler(Animals source, EventArgs args);
        public event AnimalSleepEventHandler AnimalWakes;
        #endregion
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
            System.Threading.Thread.Sleep(2000);
            OnAnimalWakeUp();
        }
        public void Speak()
        {
            Console.WriteLine($"{_Name} : Makes a sound - {_Sound}");
        }
        public void OnAnimalWakeUp()
        {
            if(AnimalWakes != null)
            {
                AnimalWakes(this, EventArgs.Empty);
            }
        }
        #endregion

    }

}
