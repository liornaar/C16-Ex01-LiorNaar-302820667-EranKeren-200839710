using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace C16_Ex02_FacebookAPI
{
    internal class FaceBookEventProxy
    {
        public Event m_FbEvent { get; set; }

        public string Picture
        {
            get
            {
                return m_FbEvent.PictureNormalURL;
            }
        }

        public string Location
        {
            get
            {
                return m_FbEvent.Place.Name;
            }
        }

        public FaceBookEventProxy(Event i_Event)
        {
            m_FbEvent = i_Event;
        }

        public string Name
        {
            get
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(m_FbEvent.Name);
                stringBuilder.Append(string.Format(" ({0}) ", m_FbEvent.AttendingUsers.Count));
                return stringBuilder.ToString();
            }
        }
    }
}
