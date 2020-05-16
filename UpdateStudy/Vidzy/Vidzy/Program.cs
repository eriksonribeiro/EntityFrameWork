using Vidzy.Migrations;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity.Migrations.Model;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {

            /* //1 - Add New Video
               UpdatingData.AddVideos( new Video
               { Name        = "Terminator 1"
                ,ReleaseDate = new DateTime(1984,08,26)
                ,GenreId     = 2
                ,Classification = Classification.Silver
               });

               // 2 - Add New Tag
               UpdatingData.AddTags("classics","drama");

               // 3 - Add New TagVideo
               UpdatingData.AddTagToVideo(1,"classics", "drama","comedy");

               // 4 - Remove Tag from Video
               UpdatingData.RemoveTagToVideo(1, "comedy");

               // 5 - Remove Video
               UpdatingData.RemoveVideo(1);

              // 6 - Remove Genre and Dependency
                     */
            UpdatingData.RemoveGenre(2, enforceDeletingVideos: true);
        }
    }
}
