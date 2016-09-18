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
using C16_Ex02_FacebookAPI;
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
            m_ButtonsList = new List<Button> { m_PostButton, m_SongPostButton, m_QuoteButton };
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

            m_LoadingLabelComment.Show();
            m_LoadingLabelLike.Show();
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
                m_LoadingLabelLike.Invoke(new Action(() => m_LoadingLabelLike.Visible = false));
            }

            if (maxCommentUrl != null)
            {
                m_MostCommentedPictureBox.LoadAsync(maxCommentUrl);
                m_LoadingLabelComment.Invoke(new Action(() => m_LoadingLabelComment.Visible = false));
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
            postBindingSource.DataSource = m_FacebookApiHandler.m_User.Posts;
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
                string resultLyrics = m_FacebookApiHandler.GetSongLyrics(m_SongNameTextBox.Text, m_ArtistTextBox.Text);

                if (!string.IsNullOrEmpty(resultLyrics))
                {
                    m_FacebookApiHandler.m_User.PostStatus(
                        i_StatusText:
                            string.Format("{0} - {1}\n {2}", m_ArtistTextBox.Text, m_SongNameTextBox.Text, resultLyrics),
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void m_QuoteButton_Click(object sender, EventArgs e)
        {
            string radioButtonString = getTextFromCheckedButton();
            if (radioButtonString != null)
            {
                InspirationalQuote quotePoster = InspirationalQuoteFactory.GetQuoter(radioButtonString.ToLower());
                string quote = quotePoster.getQoute();
                m_FacebookApiHandler.m_User.PostStatus(quote);
            }
        }

        private string getTextFromCheckedButton()
        {
            string buttonText = null;
            RadioButton selectedButton = m_QuotesGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (selectedButton != null)
            {
                buttonText = selectedButton.Text;
            }

            return buttonText;
        }

        private void postBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        
    }
}
