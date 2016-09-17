using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using C16_Ex02_FacebookAPI.com.wikia.lyrics;

namespace C16_Ex02_FacebookAPI
{
    public class LyricsPoster
    {
        private static LyricsPoster m_Instance;

        private readonly LyricWiki m_LyricsHandler = new LyricWiki();

        private LyricsPoster()
        {
        }

        public static LyricsPoster Instance
        {
            get
            {
                if (m_Instance == null)
                {
                    m_Instance =  new LyricsPoster();
                }

                return m_Instance;
            }
        }

        public string GetSongLyrics(string i_Artist, string i_Title)
        {
            string result = null;
            LyricsResult lyricsResult = m_LyricsHandler.getSongResult(i_Artist, i_Title);
            if (!string.Equals("Not found", lyricsResult.lyrics))
            {
                Encoding iso8859 = Encoding.GetEncoding("ISO-8859-1");
                result = Encoding.UTF8.GetString(iso8859.GetBytes(lyricsResult.lyrics));
            }

            return result;
        }
    }
}
