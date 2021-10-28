using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    #region AllAnimals
    interface IEat
    {
        string _Diet { get; set; }
        void Eat();
    }
    interface ISleep
    {
        int _HoursOfSleep { get; set; }
        void Sleep();
    }
    interface ISpeak
    {
        string _Sound { get; set; }
        void Speak();
    }
    #endregion
    //Land dwelling animals
    interface IWalk
    {
        int _NumLegs { get; set; }
        void Walk();
    }
    //Birds
    interface IFly
    {
        int _NumWings { get; set; }
        void Fly();
    }
    //Sea Creatures
    interface ISwim
    {
        int _NumFins { get; set; }
        void Swim();
    }
    interface IAnimal : IEat,ISpeak,ISleep
    { }
}
