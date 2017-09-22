using System;

namespace _04.OnlineRadioDatabase
{
    public class Song
    {
        private string artistName;
        private string songName;
        private string length;

        public Song(string artistName, string songName, string length)
        {
            this.ArtistName = artistName;
            this.songName = songName;
            this.length = length;
        }

        public string ArtistName
        {
            get { return this.artistName; }
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new ArgumentException("Invalid song");
                }
                this.artistName = value;
            }
        }
    }
}
