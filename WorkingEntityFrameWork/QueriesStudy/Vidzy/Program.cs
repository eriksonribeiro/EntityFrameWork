using System;
using System.Runtime.Remoting.Contexts;
using Vidzy.Migrations;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {           
            //Exercise 6 - Queries with LINQ
            ExecuteQueriesExercises.Exercise6();

            //Exercise 7 - Lazy, Eager and Explicit Loading
            ExecuteQueriesExercises.Exercise7();

            Console.ReadKey();
        }
    }
}
