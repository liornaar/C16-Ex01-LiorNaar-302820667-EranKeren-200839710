using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace C16_Ex01_FacebookAPI
{
    internal class MotivationalQuote : InspirationalQuote
    {
        public override string getQoute()
        {
            string[] readText = File.ReadAllLines("..//..//motivational.txt");
            return readText[rand.Next(0, readText.Length)];
        }
    }
}
