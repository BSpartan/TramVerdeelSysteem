using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSLibrary
{
    public class Remise
    {
        public string Name { get; private set; }

        public Remise(string name)
        {
            this.Name = name;
        }
    }
}