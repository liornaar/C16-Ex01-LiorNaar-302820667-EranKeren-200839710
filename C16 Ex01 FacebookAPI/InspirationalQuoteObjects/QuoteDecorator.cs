using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using C16_Ex01_FacebookAPI;

namespace C16_Ex02_FacebookAPI
{
    internal class QuoteDecorator : InspirationalQuote
    {
        InspirationalQuote m_Quoter;

        public QuoteDecorator(InspirationalQuote i_Quoter)
        {
            m_Quoter = i_Quoter;
        }

        public override string getQoute()
        {
            return m_Quoter.getQoute();
        }
    }
}
