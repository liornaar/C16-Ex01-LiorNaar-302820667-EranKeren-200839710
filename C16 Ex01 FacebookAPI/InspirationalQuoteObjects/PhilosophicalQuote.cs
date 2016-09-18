using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace C16_Ex01_FacebookAPI
{
   internal class PhilosophicalQuote : InspirationalQuote
    {
        public override string getQoute()
        {
            string[] readText = File.ReadAllLines("..//..//philosophical.txt");
            return readText[Rand.Next(0, readText.Length)];
        }
    }
}
