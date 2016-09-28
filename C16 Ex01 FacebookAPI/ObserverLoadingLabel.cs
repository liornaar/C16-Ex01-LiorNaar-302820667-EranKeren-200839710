using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C16_Ex02_FacebookAPI
{
    public class ObserverLoadingLabel : IObserver<PictureBox>
    {
        public PictureBox m_Picturebox { get; set; }
        public bool m_Hidden { get; set; }
        public Image m_LoadingImage { get; set; }

        public ObserverLoadingLabel(PictureBox i_Picture)
        {
            m_Picturebox = i_Picture;
            m_Hidden = false;
            m_Picturebox.Image = Image.FromFile("default.gif");
        }

        public void OnNext(PictureBox value)
        {
        }

        public void OnError(Exception error)
        {
            m_Picturebox.Invoke(new Action(() => m_Picturebox.Image = Image.FromFile("error.png")));
        }

        public void OnCompleted()
        {
            m_Picturebox.Invoke(new Action(() => m_Picturebox.Hide()));
        }
    }
}
