using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace botiloid
{
    class BotNotInitException : Exception
    {
        public BotNotInitException(string msg)
            : base(msg)
        { }
    }
}
