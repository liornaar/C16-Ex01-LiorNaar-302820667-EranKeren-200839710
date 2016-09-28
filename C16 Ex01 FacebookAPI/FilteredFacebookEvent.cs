using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace C16_Ex02_FacebookAPI
{
    public class FilteredFacebookEvent : IEnumerable<FacebookEvent>
    {
        private readonly List<Event> m_Facebookevents;

        public FilteredFacebookEvent(List<Event> i_Events)
        {
            m_Facebookevents = i_Events;
        }
        public IEnumerator<FacebookEvent> GetEnumerator()
        {
            foreach (Event mFacebookevent in m_Facebookevents.Where(x => x.Place != null && x.AttendingUsers.Count > 10))
            {
                yield return new FacebookEvent() {Name = mFacebookevent.Name, Location = mFacebookevent.Place.Name, PictureUrl = mFacebookevent.PictureNormalURL};
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
