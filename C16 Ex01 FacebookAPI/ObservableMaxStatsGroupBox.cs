using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace C16_Ex02_FacebookAPI
{
    public class ObservableMaxStatsGroupBox : IObservable<PictureBox>
    {
        private List<IObserver<PictureBox>> m_Observers;

        public ObservableMaxStatsGroupBox()
        {
            m_Observers = new List<IObserver<PictureBox>>();
        }
        public IDisposable Subscribe(IObserver<PictureBox> i_Observer)
        {
            if (!m_Observers.Contains(i_Observer))
            {
                m_Observers.Add(i_Observer);
                i_Observer.OnNext(null);
            }

            return null;
        }

        public void UnSubScribe(IObserver<PictureBox> i_Observer)
        {
            if (m_Observers.Contains(i_Observer))
            {
                m_Observers.Remove(i_Observer);
            }
        }

        public void OnDataLoaded(bool success)
        {
            foreach (IObserver<PictureBox> mObserver in m_Observers)
            {
                if (success)
                {
                    mObserver.OnCompleted();
                }
                else
                {
                    mObserver.OnError(null);
                }
            }
        }

        public void LoadUserPhotos(List<Photo> userPhotos, PictureBox i_Liked, PictureBox i_Comment)
        {
            int maxComment;
            string maxCommentUrl;
            string maxLikedUrl = maxCommentUrl = null;
            int maxLiked = maxComment = 0;

            foreach (Photo photo in userPhotos)
            {
                maxLikedUrl = newMax(ref maxLiked, photo.LikedBy.Count) ? photo.PictureNormalURL : maxLikedUrl;
                maxCommentUrl = newMax(ref maxComment, photo.Comments.Count) ? photo.PictureNormalURL : maxCommentUrl;
            }

            if (maxLikedUrl != null && maxCommentUrl != null)
            {
                OnDataLoaded(true);
                i_Liked.LoadAsync(maxLikedUrl);
                i_Comment.LoadAsync(maxCommentUrl);
            }

            else
            {
                OnDataLoaded(false);
            }
        }

        private bool newMax(ref int io_OldVal, int i_NewVal)
        {
            bool changed = false;

            if (io_OldVal < i_NewVal)
            {
                io_OldVal = i_NewVal;
                changed = true;
            }

            return changed;
        }
    }

    internal class Unsubscriber<PicturebBox> : IDisposable
    {
        private List<IObserver<PicturebBox>> m_Observers;
        private IObserver<PicturebBox> m_Observer;

        internal Unsubscriber(List<IObserver<PicturebBox>> i_Observers, IObserver<PictureBox> i_Observer )
        {
            m_Observers = i_Observers;
        }

        public void Dispose()
        {
            if (m_Observers.Contains(m_Observer))
                m_Observers.Remove(m_Observer);
        }
    }
}
