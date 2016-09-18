using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C16_Ex02_FacebookAPI
{
    internal class FacebookApiHandler
    {
        private LyricsPoster m_SongHandler;

        public User m_User { get; set; }
        public string m_AccessToken { get; set; }

        public void UserLogin()
        {
            LoginResult result = FacebookWrapper.FacebookService.Login("2287434634730573", "public_profile", "user_friends", "email", "user_posts", "user_videos", "user_events", "user_photos");
            m_User = result.LoggedInUser;
            m_AccessToken = result.AccessToken;
        }

        // This is a web service to fetch song lyrics from http://lyrics.wikia.com/wiki/Lyrics_Wiki
        public string GetSongLyrics(string i_Title, string i_Artist)
        {
            string result = null;

            m_SongHandler = LyricsPoster.Instance;
            result = m_SongHandler.GetSongLyrics(i_Artist, i_Title);

            return result;
        }

        public List<Photo> GetUserPhotos()
        {
            List<Photo> allUsersPhotos = new List<Photo>();

            foreach (Album album in m_User.Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    allUsersPhotos.Add(photo);
                }
            }

            return allUsersPhotos;
        }
    }
}