using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class AdventureFactory
    {
        static public ICharacter GetCharacter(string cha)
        {
            if (cha == "mage")
                return new Mage();
            else
                return new Fighter();
        }
    }
}
