using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    class ZooKeeper
    {
        public void OnAnimalWakeUp(Animals source, EventArgs args)
        {
            Console.WriteLine($"The zoo keeper feeds the {source._Name} some {source._Diet}");
        }
    }
}
