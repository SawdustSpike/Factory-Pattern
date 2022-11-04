using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Mage : ICharacter
    {
        public void Create()
        {
            Console.WriteLine("Go find a pointy hat while I create your Mage!");
        }
    }
}
