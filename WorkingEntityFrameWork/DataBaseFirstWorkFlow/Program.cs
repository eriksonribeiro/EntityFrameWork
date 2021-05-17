using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirstWorkFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            var vidzyDBContext = new VidzyDBContext();
            /* 
            First Iteration
                   vidzyDBContext.AddVideo("Amigos Para Sempre", DateTime.Parse("2019-01-01"), "Family");
                   vidzyDBContext.AddVideo("Vidro", DateTime.Parse("2019-01-01"), "Thriller");
                   vidzyDBContext.AddVideo("Como Treinar o Seu Dragão", DateTime.Parse("2019-01-01"), "Family");
                   vidzyDBContext.AddVideo("Uma Aventura LEGO 2", DateTime.Parse("2019-01-01"), "Family");
                   vidzyDBContext.AddVideo("Alita: Anjo de Combate", DateTime.Parse("2019-01-01"), "Action");
                   vidzyDBContext.AddVideo("O Menino que Queria Ser Rei", DateTime.Parse("2019-01-01"), "Romance");
                   vidzyDBContext.AddVideo("Capitã Marvel", DateTime.Parse("2019-01-01"), "Action");
                   vidzyDBContext.AddVideo("Us", DateTime.Parse("2019-01-01"), "Thriller");

            Second Iteration
                   vidzyDBContext.AddVideo("Assunto de Familia", DateTime.Parse("2018-01-01"), "Romance");
                   vidzyDBContext.AddVideo("Pantera Negra", DateTime.Parse("2019-01-01"), "Action");
                   vidzyDBContext.AddVideo("Ponto Cego", DateTime.Parse("2019-01-01"), "Thriller");
            
            Third Iteration */

            vidzyDBContext.AddVideo("Assunto de Familia", DateTime.Parse("2018-01-01"), "Romance", (byte)Classification.Silver);
            vidzyDBContext.AddVideo("Pantera Negra", DateTime.Parse("2019-01-01"), "Action", (byte)Classification.Gold);
            vidzyDBContext.AddVideo("Ponto Cego", DateTime.Parse("2019-01-01"), "Thriller", (byte)Classification.Platinum);
        }
    }
}
