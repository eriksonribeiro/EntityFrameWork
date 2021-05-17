using System;
using System.Linq;
using AcessDataBase.BD;

namespace AcessDataBase.Entities
{
    public static class Conexoes  
    {
        #region Code First
        //Conecta no banco e insere dados
        public static void CriarCarro(LojaContexto BancoDados, string NomeCarro)
        {
            var NovoCarro = new Carro()
            {
                 NomeCarro = NomeCarro
                ,DataFabricacao = DateTime.Now
            };

            BancoDados.Carros.Add(NovoCarro);
            BancoDados.SaveChanges();

            foreach (var item in BancoDados.Carros)
            {
                Console.WriteLine($"ID do Carro: {item.CarroID} - Nome do Carro: {item.NomeCarro}");
            }
        }

        //Atualiza os dados da tabela, usando o LINQ para consulta
        public static void AtualizarCarro(LojaContexto BancoDados)
        {
            var MeuCarro = (from c in BancoDados.Carros
                            where c.NomeCarro == "S2000"
                            select c).FirstOrDefault(); //LINQ

            MeuCarro.Cor = "Prata";
            MeuCarro.Ano = 2000;
            MeuCarro.Marca = "Honda";

            BancoDados.SaveChanges(); //salva os dados
        }

        public static void CodeFirst()
        {
            using (var BancoDados = new LojaContexto())
            {
                Console.Write("Entre com o nome do carro: ");
                var NomeCarro = Console.ReadLine();

                CriarCarro(BancoDados, NomeCarro); //Chamado o Metodo Criar Carro
                AtualizarCarro(BancoDados); // Chama o metodo Atualiza Carro


                var MeuCarro = (from c in BancoDados.Carros
                                where c.NomeCarro == "S3000"
                                select c).FirstOrDefault(); //LINQ

                // BancoDados.Carros.Remove(MeuCarro); //remover

                Console.ReadKey();
            }
        }
        #endregion

        #region Conexão com Banco

        public static void SQLQuery()
        {
            using (var SQLBanco = new AcessDataBaseEntities())
            {
                foreach (var artista in SQLBanco.artista)
                {
                    Console.WriteLine($"Artista: {artista.nomeartista}");
                }

                var artistas = (from a in SQLBanco.artista
                                where a.nomeartista == "Rihanna"
                                select a).FirstOrDefault();

                Console.WriteLine($"{artistas.nomeartista}");

                Console.ReadKey();
            }
        }

        #endregion
    }
}
