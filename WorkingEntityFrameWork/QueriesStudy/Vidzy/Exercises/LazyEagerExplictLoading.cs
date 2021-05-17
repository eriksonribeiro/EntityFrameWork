using System;
using System.Linq;
using System.Data.Entity;

namespace Vidzy
{
    public class LazyEagerExplictLoading
    {
        public VidzyContext context = new VidzyContext();
        public void LazyLoading()
        {
            var movies = context.Videos.ToList();

            Console.WriteLine("**** Lazy Loading\n");

            foreach (var movie in movies)
              Console.WriteLine($"Movie: {movie.Name} - Genre: {movie.Genre.Name}");
        }

        public void EagerLoading()
        {
            var movies = context.Videos.Include(g => g.Genre).ToList();

            Console.WriteLine("**** Earger Loading\n");

            foreach (var movie in movies)
              Console.WriteLine($"Movie: {movie.Name} - Genre: {movie.Genre.Name}");

        }

        public void ExplictLoading()
        {
            var movies = context.Videos.ToList();
            context.Genres.Load();

            Console.WriteLine("**** Explicit Loading\n");

            foreach (var movie in movies)
                Console.WriteLine($"Movie: {movie.Name} - Genre: {movie.Genre.Name}");

        }
    }
}
