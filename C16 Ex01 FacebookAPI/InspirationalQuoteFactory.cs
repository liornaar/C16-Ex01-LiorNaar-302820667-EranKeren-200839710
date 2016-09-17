using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C16_Ex01_FacebookAPI
{
    static class InspirationalQuoteFactory
    {
        public static InspirationalQuote GetQuoter(string type)
        {
            InspirationalQuote quoter = null;

            switch (type)
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
