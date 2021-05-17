using System;
using AcessDataBase.Entities;

namespace AcessDataBase
{

    class Program
    {
        static void Main(string[] args)
        {
           //CodeFirst();

           Conexoes.SQLQuery();
           Console.ReadKey();
           
        }
    }
}
