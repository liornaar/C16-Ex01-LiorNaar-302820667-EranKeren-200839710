using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using C16_Ex01_FacebookAPI;

namespace C16_Ex02_FacebookAPI
{
    internal abstract class QuoteDecorator : InspirationalQuote
    {
        protected InspirationalQuote m_Quoter;

        public QuoteDecorator(InspirationalQuote i_Quoter)
        {
            m_Quoter = i_Quoter;
        }

        public abstract override string getQoute();
        
    }
}
