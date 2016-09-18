using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C16_Ex01_FacebookAPI
{
    internal abstract class InspirationalQuote
    {
        public Random Rand = new Random();

        public abstract string getQoute();
    }
}
