using System;
using System.Collections.Generic;
using System.Text;

namespace Class08Ex._2
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }

        public Person() { }

        public Person(int id, string firstName, string lastName, int age, Genre favoriteMusicType, List<Song> favoriteSongs)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteMusicType = favoriteMusicType;
            FavoriteSongs = favoriteSongs;

        }

        public bool GetFavSongs()
        {
            if(FavoriteSongs.Count < 1)
            {
                Console.WriteLine("This person hates music");
            } else
            {
                foreach(Song s in FavoriteSongs)
                {
                    Console.WriteLine($"{s.Title}");
                }
            }
            return false;
        }

    }
}
