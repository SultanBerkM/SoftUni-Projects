using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> songList = new Queue<string>();
            for (int i = 0; i < songs.Length; i++)
            {
                songList.Enqueue(songs[i]);
            }

            string[] command = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            while (true)
            {
                if (command[0] == "Play")
                {
                    songList.Dequeue();
                    if (songList.Count == 0)
                    {
                        break;
                    }
                }
                else if (command[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", songList));
                }
                else if (command[0] == "Add")
                {
                    string currentSong = string.Empty;
                    for (int i = 1; i < command.Length; i++)
                    {
                        currentSong+=command[i]+" ";
                    }

                    currentSong = currentSong.TrimEnd();

                    if (songList.Contains(currentSong))
                    {
                        Console.WriteLine($"{currentSong} is already contained!");
                    }
                    else
                    {
                        songList.Enqueue(currentSong);
                    }
                    
                }
                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine("No more songs!");
        }
    }
}
