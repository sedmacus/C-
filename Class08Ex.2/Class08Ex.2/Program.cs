using System;
using System.Collections.Generic;
using System.Linq;

namespace Class08Ex._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> martinsSongs = new List<Song>();
            List<Song> pecesSongs = new List<Song>();

            
            Song eminem = new Song("My name Is", 270, Genre.Hip_Hop);
            Song hotSince82 = new Song("Eye of the storm", 360, Genre.Techno);
            Song beethoven = new Song("Turkish March", 120, Genre.Classical);
            Song acDc = new Song("T.N.T.", 300, Genre.Rock);
            Song justinBieber = new Song("Hold on", 250, Genre.Classical);
            Song maroon5 = new Song("Sugar", 340, Genre.Rock);
            Song neYo = new Song("So sick", 400, Genre.Hip_Hop);
            Song nelly = new Song("Dilemma", 150, Genre.Hip_Hop);
            Song avicii = new Song("Waiting for Love", 500, Genre.Techno);
            Song demiLovato = new Song("Sorry Not Sorry", 320, Genre.Classical);
            Song fooFighters = new Song("All my life", 400, Genre.Rock);
            Song greenDay = new Song("American Idiot", 420, Genre.Rock);
            Song johnLengend = new Song("All of me", 310, Genre.Hip_Hop);
            Song michaelJackson = new Song("Beat it", 430, Genre.Classical);

            List<Song> listAllSongs = new List<Song>() { eminem , hotSince82, beethoven , acDc, justinBieber, maroon5 , neYo , nelly , avicii ,
            demiLovato, fooFighters,  greenDay, johnLengend, michaelJackson };

            martinsSongs.Add(beethoven);
            martinsSongs.Add(eminem);
            martinsSongs.Add(hotSince82);
            martinsSongs.Add(acDc);

            Person martin = new Person(1, "Martin", "Brzovski", 30, Genre.Techno, martinsSongs);

            Person pece = new Person(2, "Pece", "Pecovski", 23, Genre.Classical, pecesSongs);

            List<Song> jerrysSongs = listAllSongs.Where(s => s.Title.StartsWith("B")).ToList();
            Person jerry = new Person(3, "Jerry", "Jerrovski", 21, Genre.Classical, jerrysSongs);

            List<Song> mariaSongs = listAllSongs.Where(s => s.Length > 360).ToList();
            Person maria = new Person(4, "Maria", "Petrovska", 28, Genre.Rock, mariaSongs);

            List<Song> janesSongs = listAllSongs.Where(s => s.Genre == Genre.Rock).ToList();
            Person jane = new Person(5, "Jane", "Janovsky", 18, Genre.Hip_Hop, janesSongs);

            List<Song> stefansSongs = listAllSongs.Where(s => s.Length < 180 && s.Genre == Genre.Hip_Hop).ToList();
            Person stefan = new Person(6, "Stefan", "Ilievski", 31, Genre.Hip_Hop, stefansSongs);

            List<Person> persons = new List<Person> { martin, pece, jerry, maria, jane, stefan };

            List<Person> personsWith4OrMoreSongs = persons.Where(p => p.FavoriteSongs.Count > 4).ToList();

            

            

            



        }
    }
}
