﻿using System;
using System.Text;
using System.Windows.Forms;
using C16_Ex01_FacebookAPI.com.wikia.lyrics;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C16_Ex01_FacebookAPI
{
    internal class FacebookApiHandler
    {
        public User m_User { get; set; }
        public string m_AccessToken { get; set; }
        private LyricWiki m_SongHandler = new LyricWiki();

        public void UserLogin()
        {
            LoginResult result = FacebookWrapper.FacebookService.Login("2287434634730573",
                "public_profile", "user_friends", "email", "user_posts", "user_videos", "user_events");
            m_User = result.LoggedInUser;
            m_AccessToken = result.AccessToken;
        }


        public string GetSongLyrics(string i_Title, string i_Artist)
        {
            string result = null;
            LyricsResult lyricsResult = m_SongHandler.getSongResult(i_Artist, i_Title);
            
            Encoding iso8859 = Encoding.GetEncoding("ISO-8859-1");
            result = Encoding.UTF8.GetString(iso8859.GetBytes(lyricsResult.lyrics));
            return result;
        }
    }
}