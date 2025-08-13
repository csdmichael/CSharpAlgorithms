using System;
using System.Collections.Generic;

public class Song
{
    private string name;
    public Song NextSong { get; set; }

    public Song(string name)
    {
        this.name = name;
    }

    public bool IsRepeatingPlaylist()
    {
        bool isRepeat = false;
        Dictionary<string, string> prevSongs = new Dictionary<string, string>();
        prevSongs.Add(name, name);

        while (this.NextSong != null)
        {
            if (prevSongs.ContainsKey(this.NextSong.name))
            {
                return true;
            }
            else
            {
                prevSongs.Add(this.NextSong.name, this.NextSong.name);
                this.NextSong = this.NextSong.NextSong;
            }
        }

        return isRepeat;
    }

    /*
    public static void Main(string[] args)
    {
        Song first = new Song("Hello");
        Song second = new Song("Eye of the tiger");

        first.NextSong = second;
        second.NextSong = first;

        Console.WriteLine(first.IsRepeatingPlaylist());
        Console.ReadLine();
    }
    */
}