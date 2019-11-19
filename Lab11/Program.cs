using System;
using System.Collections.Generic;
namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> genre = new List<string>()
            {
            "Horror", "Animated", "Drama", "Scifi"
            };


            List<Movie> movieList = new List<Movie>
            {
                {new Movie("Interstellar", genre[3])},
                {new Movie ("Princess Mononoke", genre[1]) },
                {new Movie("Seven", genre[0]) },
                {new Movie("Howls Moving Castle", genre[1]) },
                {new Movie("The Matrix", genre[3]) },
                {new Movie("Castaway", genre[2]) },
                {new Movie("Star Wars", genre[3]) },
                {new Movie("The Tree of Life",genre[2]) },
                {new Movie("Get Out", genre[0])},
                {new Movie("Alien", genre[0]) },
                {new Movie("Close Encounters of the Third Kind", genre[3]) }
            };

            movieList.Sort((a,b)=> a.Title.CompareTo(b.Title));

            Console.WriteLine("Hi welcome to the Movie database!\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Please select a number from the list below");

                int i = 1;
                foreach (string index in genre)
                {
                    Console.WriteLine($"{i}: {index}");
                    i++;
                }

                int userNumber = Movie.GetNumber(genre, movieList);

                foreach (Movie movie in movieList)
                {
                    if (movie.Catagory == genre[userNumber - 1])
                    {
                        Console.WriteLine(movie.Title);
                    }
                }
                repeat = Movie.Repeater();
            }
            Console.WriteLine("GoodBye!");
        }
    }
}
