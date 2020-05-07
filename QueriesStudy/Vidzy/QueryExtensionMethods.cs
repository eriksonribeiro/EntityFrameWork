using System;
using System.Linq;

namespace Vidzy
{
    public class QueryExtensionMethods: Query
    {
        public void QueryOneDotone()
        {
            var movies = context.Videos.Where(v => v.Genre.Name == "Action").OrderBy(v => v.Name);

            ShowResult(movies, "Action Movies");
        }

        public void QueryTwoDotOne()
        {
            var movies = context.Videos
                         .Where(v => v.Genre.Name == "Drama" && v.Classification == Classification.Gold)
                         .OrderBy(v => v.ReleaseDate);

            ShowResult(movies, "Gold Drama Movies");
        }

        public void QueryThreeDotOne()
        {
            var movies = context.Videos.Select(v => new {Video = v.Name, Genre = v.Genre.Name});

            Console.WriteLine($"***************Movie and Genre*******************");
            Console.WriteLine("");

            foreach (var movie in movies)
                Console.WriteLine($"Movie: {movie.Video} Genre: {movie.Genre}");

            Console.WriteLine("");
        }

        public void QueryFour()
        {
            var groups = context.Videos.GroupBy(v => v.Classification)
                .Select(g => new {Classification = g.Key.ToString(), Videos = g.OrderBy(v => v.Name)});

            Console.WriteLine($"***************Movie by Classification*******************\n");

            foreach (var g in groups)
            {
                Console.WriteLine($"Classification: {g.Classification}");

                foreach (var movie in g.Videos)
                    Console.WriteLine($"\t {movie.Name}");

                Console.WriteLine("");
            }
        }

        public void QueryFive()
        {
            Console.WriteLine($"***************Count Classification*******************\n");

            var classification = context.Videos.GroupBy(v => v.Classification)
                                 .Select(g => new { Name = g.Key.ToString(), qtd = g.Count() })
                                 .OrderBy(c => c.Name);

            foreach (var classif in classification)
                Console.WriteLine($"\t Classificação: {classif.Name} ({classif.qtd})");

            Console.WriteLine("");
        }

        public void QuerySix()
        {
            Console.WriteLine($"***************Count Genre/Movie*******************\n");

            var genremovie = context.Genres
                              .GroupJoin(context.Videos, g => g.Id, v => v.GenreId, (genre, videos) => new
                              {
                                  Name = genre.Name,
                                  VideosQtd = videos.Count()
                              })
                              .OrderByDescending(g => g.VideosQtd);

            foreach (var genre in genremovie)
                Console.WriteLine($"\t Classificação: {genre.Name} ({genre.VideosQtd})");

            Console.WriteLine("");
        }
    }
}
