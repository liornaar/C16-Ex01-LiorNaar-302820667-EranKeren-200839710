using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using C16_Ex01_FacebookAPI.com.wikia.lyrics;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C16_Ex01_FacebookAPI
{
    internal class FacebookApiHandler
    {
        private LyricWiki m_SongHandler = new LyricWiki();
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
            LyricsResult lyricsResult = m_SongHandler.getSongResult(i_Artist, i_Title);
            if (!string.Equals("Not found", lyricsResult.lyrics))
            {
                Encoding iso8859 = Encoding.GetEncoding("ISO-8859-1");
                result = Encoding.UTF8.GetString(iso8859.GetBytes(lyricsResult.lyrics));
            }

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