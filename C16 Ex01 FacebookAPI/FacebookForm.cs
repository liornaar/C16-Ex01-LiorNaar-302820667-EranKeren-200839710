using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C16_Ex01_FacebookAPI
{
    public partial class FacebookForm : Form
    {
        private FacebookApiHandler m_FacebookApiHandler;

        public FacebookForm()
        {
            InitializeComponent();
            Color myColor = Color.FromArgb(120, Color.White);
            m_RememberMeCheckBox.BackColor = myColor;
            m_RememberMeCheckBox.Parent = m_CoverPicture;
            m_ButtonsList = new List<Button> { m_PostButton, m_SongPostButton };
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
            m_RememberMeCheckBox.Hide();
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
            Thread pictureStatThread = new Thread(loadPictureStatistics);
            pictureStatThread.Start();
        }

        private void loadPictureStatistics()
        {
            int maxComment;
            string maxCommentUrl;
            string maxLikedUrl = maxCommentUrl = null; 
            int maxLiked = maxComment = 0;
            List<Photo> userPhotos = m_FacebookApiHandler.GetUserPhotos();

            foreach (Photo photo in userPhotos)
            {
                maxLikedUrl = newMax(ref maxLiked, photo.LikedBy.Count) ? photo.PictureNormalURL : maxLikedUrl;
                maxCommentUrl = newMax(ref maxComment, photo.Comments.Count) ? photo.PictureNormalURL : maxCommentUrl;
            }

            if (maxLikedUrl != null)
            {
                m_MostLikedPictureBox.LoadAsync(maxLikedUrl);
            }

            if (maxCommentUrl != null)
            {
                m_MostCommentedPictureBox.LoadAsync(maxCommentUrl);
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

        private void loadPictures()
        {
            m_CoverPicture.LoadAsync(m_FacebookApiHandler.m_User.Cover.SourceURL);
            m_CoverPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            m_ProfilePicture.LoadAsync(m_FacebookApiHandler.m_User.PictureNormalURL);
            m_ProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void loadEvents()
        {
            LinkedList<EventControl> eventControls = new LinkedList<EventControl>();

            m_EventsLayout.Controls.Clear();
            foreach (Event fbEvent in m_FacebookApiHandler.m_User.Events)
            {
                EventControl control = new EventControl();
                control.m_PictureUrl = fbEvent.PictureNormalURL;
                if (fbEvent.Place != null)
                {
                    control.m_EventLocation = fbEvent.Place.Name;
                }
                else
                {
                    control.m_EventLocation = "Unknown";
                }

                control.m_EventName = fbEvent.Name;
                eventControls.AddLast(control);
                m_EventsLayout.Controls.Add(control);
            }
        }

        private void loadPosts()
        {
            m_PostsListBox.Items.Clear();
            m_PostsListBox.DisplayMember = "Description";
            foreach (Post post in m_FacebookApiHandler.m_User.Posts)
            {
                if (post.Message != null)
                {
                    m_PostsListBox.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    m_PostsListBox.Items.Add(post.Caption);
                }
                else
                {
                    m_PostsListBox.Items.Add(string.Format("[{0}]", post.Type));
                }
            }
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(m_PostTextBox.Text))
            {
                m_FacebookApiHandler.m_User.PostStatus(m_PostTextBox.Text);
            }
        }

        private void songPostButton_Click(object sender, EventArgs e)
        {
            m_LyricsErrorLabel.Visible = false;
            if (validateSongPostRequest())
            {
                string result = m_FacebookApiHandler.GetSongLyrics(m_SongNameTextBox.Text, m_ArtistTextBox.Text);

                if (!string.IsNullOrEmpty(result))
                {
                    m_FacebookApiHandler.m_User.PostStatus(
                        i_StatusText:
                            string.Format("{0} - {1}\n {2}", m_ArtistTextBox.Text, m_SongNameTextBox.Text, result),
                        i_Link: m_SongUrl.Text);
                }
                else
                {
                    m_LyricsErrorLabel.Visible = true;
                }
            }
        }

        private bool validateSongPostRequest()
        {
            bool result = true;

            if (string.IsNullOrEmpty(m_ArtistTextBox.Text) || string.IsNullOrEmpty(m_SongUrl.Text) ||
                string.IsNullOrEmpty(m_SongNameTextBox.Text))
            {
                m_ArtistTextBox.BackColor = m_SongNameTextBox.BackColor = m_SongUrl.BackColor = Color.Red;
                result = false;
            }

            return result;
        }
    }
}
