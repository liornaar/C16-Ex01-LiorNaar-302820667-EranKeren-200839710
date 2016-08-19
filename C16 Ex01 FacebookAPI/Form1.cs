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
    public partial class Form1 : Form
    {
        private User m_LoggedInUser;

        public Form1()
        {
            InitializeComponent();
            Color myColor = Color.FromArgb(120, Color.White);
            rememberMeCheckBox.BackColor = myColor;
            rememberMeCheckBox.Parent = coverPicture;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // removed , "publish_actions" authorize and 
            // result.LoggedInUser.PostLink("youtube.com/watch?v=tM7oUtMt6WU");
            LoginResult result = FacebookWrapper.FacebookService.Login("2287434634730573",
                "public_profile", "user_friends", "email", "user_posts", "user_videos", "user_events");
            if (string.IsNullOrEmpty(result.AccessToken))
            {
                MessageBox.Show(result.ErrorMessage);
            }
            else
            {
                m_LoggedInUser = result.LoggedInUser;
                fetchData();
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
            coverPicture.LoadAsync(m_LoggedInUser.Cover.SourceURL);
            coverPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePicture.LoadAsync(m_LoggedInUser.PictureNormalURL);
            profilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void loadEvents()
        {
            LinkedList<EventControl> EventControls = new LinkedList<EventControl>();
            //listBox1.Items.Clear();
            //listBox1.DisplayMember = "Name";
            flowLayoutPanel1.Controls.Clear();
            foreach (Event fbEvent in m_LoggedInUser.Events)
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
            foreach (Post post in m_LoggedInUser.Posts)
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
    }
}
