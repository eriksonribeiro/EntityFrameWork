
using System;
using System.Data.Entity;
using System.Linq;

namespace Vidzy
{
    public static class UpdatingData
    {
        public static void AddVideos(Video video)
        {
            using (var context = new VidzyContext())
            {
                context.Videos.Add(video);
                context.SaveChanges(); 
            }
        }

        public static void AddTags(params string [] tagNames)
        {
            using (var context = new VidzyContext())
            {
                var tags = context.Tags.Where(t => tagNames.Contains(t.Name)).ToList();

                foreach (var item in tagNames)
                {
                    if (!tags.Any(t => t.Name.Equals(item, StringComparison.CurrentCultureIgnoreCase)))
                    context.Tags.Add(new Tag { Name = item});
                }
                context.SaveChanges();
            }
        }

        public static void AddTagToVideo(int videoId, params string[] tagNames)
        {
            using (var context = new VidzyContext())
            {
                var tags = context.Tags.Where(t => tagNames.Contains(t.Name)).ToList();

                foreach (var item in tagNames)
                {
                    if (!tags.Any(t => t.Name.Equals(item, StringComparison.CurrentCultureIgnoreCase)))
                        tags.Add(new Tag { Name = item });
                }

                var video = context.Videos.Single(v => v.Id == videoId);

                tags.ForEach(t => video.AddTag(t));

                context.SaveChanges();
            }
        }

        public static void RemoveTagToVideo(int videoId, params string[] tagNames)
        {
            using (var context = new VidzyContext())
            {
                context.Tags.Where(t => tagNames.Contains(t.Name)).Load();

                var video = context.Videos.Single(v => v.Id == videoId);

                foreach (var item in tagNames)
                    video.RemoveTag(item);

                context.SaveChanges();
            }
         
        }
        public static void RemoveVideo(int videoId)
        {
            using (var context = new VidzyContext())
            {
                var video = context.Videos.SingleOrDefault(v => v.Id == videoId);

                if (video == null) return;

                context.Videos.Remove(video);
                context.SaveChanges();
            }
        }

        public static void RemoveGenre(int genreId, bool enforceDeletingVideos)
        {
            using (var context = new VidzyContext())
            {

                var genre = context.Genres.Include(g => g.Videos).SingleOrDefault(g => g.Id == genreId);

                if (genre == null) return;

                if (enforceDeletingVideos)
                    context.Videos.RemoveRange(genre.Videos);

                context.Genres.Remove(genre);
                context.SaveChanges();             
            }
        }
    }
}
