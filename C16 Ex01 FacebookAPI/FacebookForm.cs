using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C16_Ex01_FacebookAPI
{
    public partial class FacebookForm : Form
    {
        private FacebookApiHandler m_FacebookApiHandler;
        private User m_LoggedInUser;

        public FacebookForm()
        {
            InitializeComponent();
            Color myColor = Color.FromArgb(120, Color.White);
            rememberMeCheckBox.BackColor = myColor;
            rememberMeCheckBox.Parent = m_CoverPicture;
            m_ButtonsList = new List<Button> { postButton, button1, songPostButton };
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            m_FacebookApiHandler = new FacebookApiHandler();
            m_FacebookApiHandler.UserLogin();
            if (string.IsNullOrEmpty(m_FacebookApiHandler.m_AccessToken))
            {
                MessageBox.Show("Could not connect to Facebook");
            }
            else
            {
               fetchData();
            }

            enableButtons();
            m_ButtonLogin.Hide();
            rememberMeCheckBox.Hide();

        }

        private void enableButtons()
        {
            foreach (Button button in m_ButtonsList)
            {
                button.Enabled = true;
            }
        }


        private void fetchData()
        {
            loadPictures();
            loadEvents();
            loadPosts();
        }

        private void loadPictures()
        {
            m_CoverPicture.LoadAsync(m_FacebookApiHandler.m_User.Cover.SourceURL);
            m_CoverPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePicture.LoadAsync(m_FacebookApiHandler.m_User.PictureNormalURL);
            profilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void loadEvents()
        {
            LinkedList<EventControl> EventControls = new LinkedList<EventControl>();
            //listBox1.Items.Clear();
            //listBox1.DisplayMember = "Name";
            flowLayoutPanel1.Controls.Clear();
            foreach (Event fbEvent in m_FacebookApiHandler.m_User.Events)
            {
                EventControl control = new EventControl();
                control.PictureUrl = fbEvent.PictureNormalURL;
                if (fbEvent.Place != null)
                {
                    control.EventLocation = fbEvent.Place.Name;
                }
                else
                {
                    control.EventLocation = "Unknown";
                }
                control.EventName = fbEvent.Name;
                EventControls.AddLast(control);
                flowLayoutPanel1.Controls.Add(control);
            }

        }

        private void loadPosts()
        {

            listBox1.Items.Clear();
            listBox1.DisplayMember = "Description";
            foreach (Post post in m_FacebookApiHandler.m_User.Posts)
            {
                if (post.Message != null)
                {
                    listBox1.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBox1.Items.Add(post.Caption);
                }
                else
                {
                    listBox1.Items.Add(string.Format("[{0}]", post.Type));
                }
            }
        }


        private void eventPicture1_Click(object sender, EventArgs e)
        {

        }

        private void postButton_Click(object sender, EventArgs e)
        {
            m_LoggedInUser.PostStatus(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int maxNumOfFriends = 0;
            //User friendWithMostFriends;
            //foreach (User friend in m_LoggedInUser.Friends)
            //{
            //    if (friend.)
            //}
        }

        private void songPostButton_Click(object sender, EventArgs e)
        {
            //TODO: check if songURL is a valid url, and 
            //TODO: check if textboxes contains something or disable until input 
            string result = m_FacebookApiHandler.GetSongLyrics(m_SongNameTextBox.Text, m_ArtistTextBox.Text);
            if (!string.IsNullOrEmpty(result))
            {
               m_FacebookApiHandler.m_User.PostStatus(i_StatusText: string.Format("{0} - {1}\n {2}", m_ArtistTextBox.Text, m_SongNameTextBox.Text, result), i_Link: m_SongUrl.Text);
            }
        }

        private void songName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
