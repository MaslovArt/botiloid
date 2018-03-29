using System;

namespace botiloid.gameBot
{
    class BotNotInitException : Exception
    {
        public BotNotInitException(string msg)
            : base(msg)
        { }
    }
}
