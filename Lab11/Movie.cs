using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab11
{
    class Movie
    {
        private string title;
        private string catagory;
        
        //public string horror = "horror";
        //public string animated = "animated";
        //public string drama = "drama";
        //public string scifi = "scifi";
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Catagory
        {
            get { return catagory; }
            set { catagory = value; }
        }

        public Movie (string title, string catagory)
        {
            Title = title;
            Catagory = catagory;
        }

        public static int GetNumber(List<string> list, List<Movie> listTwo)
        {
            int userReply = 0;
            bool repeat = true;
            while (repeat)
            {
                try
                {
                    userReply = int.Parse(Console.ReadLine());
                    object test = listTwo[userReply];
                    repeat = false;
                }
                catch (Exception)
                {
                    Console.WriteLine($"Please enter a number between 1 and {list.Count}!");
                }
            }
            return userReply;
        }

        public static bool Repeater()
        {
            bool repeat = true;
            Console.WriteLine("Do you wish to continue?");
            while (repeat)
            {
                string reply = Console.ReadLine();
                if (string.IsNullOrEmpty(reply))
                {
                    Console.WriteLine("Please enter a yes or no");
                }
                else if (Regex.IsMatch(reply.ToLower(), @"(y)|(yes)"))
                {
                    repeat = false;
                    return true;
                }
                else if (Regex.IsMatch(reply.ToLower(), @"(n)|(no)"))
                {
                    repeat = false;
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter a yes or no");
                }
               
            }
            return true;
        }

    }
}
