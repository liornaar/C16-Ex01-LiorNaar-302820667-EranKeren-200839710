using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C16_Ex01_FacebookAPI
{
    public partial class EventControl : UserControl
    {
        public string m_PictureUrl
        {
            get { return eventPicture1.ImageLocation; }
            set
            {
                eventPicture1.LoadAsync(value);
                eventPicture1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        public string m_EventLocation
        {
            get { return eventLocation1.Text; }
            set { eventLocation1.Text = value; }
        }

        public string m_EventName
        {
            get { return labelName.Text; }
            set { labelName.Text = value; }
        }

        public EventControl()
        {
            InitializeComponent();
            labelName.Parent = eventPicture1;
            Color myColor = Color.FromArgb(120, Color.White);
            labelName.BackColor = myColor;
        }
    }
}
