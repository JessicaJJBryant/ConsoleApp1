using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Song
    {
        public string title;    
        public string artist;
        public int duration ;
        public static int songCount = 0;    //This is our static attribute. It is shared by all the objects in the Song class. It's going to be set to 0 initially and then iterate as more songs are added.  
        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;    //now every time a song object is created, the songCount will go up
        }
        public int getSongCount()   //creating a method using the static class attribute so that we can identify the song count after each of the individual songs (see Program.cs to see how this is used)
        {
            return songCount;
        }
    }
}
