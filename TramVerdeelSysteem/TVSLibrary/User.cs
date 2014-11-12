using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSLibrary
{
    public abstract class User
    {
        public int UserId { get; private set; }

        public string Name { get; private set; }

        public int Function { get; private set; }

        public User(int userid, string name, int function)
        {
            this.UserId = userid;
            this.Name = name;
            this.Function = function;
        }
    }
}
