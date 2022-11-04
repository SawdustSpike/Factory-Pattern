using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Fighter : ICharacter
    {
        public void Create()
        {
            Console.WriteLine("Work on your grunts while I whip up a Fighter for you");
        }
    }
}
