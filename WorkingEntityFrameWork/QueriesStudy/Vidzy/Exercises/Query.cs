using System;
using System.Collections.Generic;
using System.Linq;

namespace Vidzy
{
    public class Query
    {
        public VidzyContext context = new VidzyContext();
   
        public void ShowResult(IQueryable<Video> context, string title)
        {
            Console.WriteLine($"******************{title}*********************\n");

            foreach (var item in context)
                Console.WriteLine($"{item.Name}");

            Console.WriteLine("");
        }

        public void QueryOne()
        {
            var movies = from v in context.Videos
                         join g in context.Genres on v.GenreId equals g.Id
                         where g.Name.Contains("Action")
                         orderby v.Name
                         select v;

            ShowResult(movies,"Action Movies");
        }

        public void QueryTwo()
        {
            var movies = from v in context.Videos
                         join g in context.Genres on v.GenreId equals g.Id
                         where v.Classification == Classification.Gold && g.Name.Contains("Drama")
                         orderby v.ReleaseDate
                         select v;

            ShowResult(movies,"Gold Drama Movies");
        }

        public void QueryThree()
        {
            var movies = from v in context.Videos
                         join g in context.Genres on v.GenreId equals g.Id
                         select new { Movie = v.Name, Genre = g.Name };

            Console.WriteLine($"***************Movie and Genre*******************");
            Console.WriteLine("");

            foreach (var movie in movies)
                Console.WriteLine($"Movie: {movie.Movie} Genre: {movie.Genre}");

            Console.WriteLine("");
        }

    }
}
