using System;
using System.Data.Entity;

namespace AcessDataBase.Entities
{
    public class LojaContexto : DbContext
    {
        public DbSet<Carro> Carros { get; set; }
    }

    public class Carro
    {
        public int CarroID { get; set; }
        public string NomeCarro { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public string Modelo { get; set; }
        public DateTime DataFabricacao { get; set;}
        public int Ano { get; set; }
    }
}
