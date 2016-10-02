using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using C16_Ex01_FacebookAPI;

namespace C16_Ex02_FacebookAPI
{
    internal class QuoteLoveDecorator : QuoteDecorator
    {
        public QuoteLoveDecorator(InspirationalQuote i_Quoter) : 
            base(i_Quoter)
        {
            
        }

        public override string getQoute()
        {
            return string.Format("{0} {1}", base.m_Quoter.getQoute(), "<3");
        }
    }
}
