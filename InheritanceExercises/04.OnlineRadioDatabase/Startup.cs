using System;
using System.Collections.Generic;

namespace _04.OnlineRadioDatabase
{
    public class Startup
    {
        public static void Main()
        {
            try
            {
                var songs = new List<Song>();

                var totalSongs = int.Parse(Console.ReadLine());

                for (int i = 0; i < totalSongs; i++)
                {
                    var songInfo = Console.ReadLine()
                        .Split();
                    var song = new Song(songInfo[0], songInfo[1], songInfo[2]);
                    Console.WriteLine("Song added.");
                    songs.Add(song);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
