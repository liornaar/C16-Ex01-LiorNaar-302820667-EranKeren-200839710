using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C16_Ex01_FacebookAPI
{
    internal static class InspirationalQuoteFactory
    {
        public static InspirationalQuote GetQuoter(string i_Type)
        {
            InspirationalQuote quoter = null;

            switch (i_Type)
            {
                case "motivational":
                    quoter = new MotivationalQuote();
                    break;
                case "philosophical":
                    quoter = new PhilosophicalQuote();
                    break;
                case "funny":
                    quoter = new FunnyQuote();
                    break;
                default:
                    quoter = new MotivationalQuote();
                    break;
            }

            return quoter;
        }
    }
}
