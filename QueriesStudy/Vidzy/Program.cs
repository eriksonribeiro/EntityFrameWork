using System;
using System.Runtime.Remoting.Contexts;
using Vidzy.Migrations;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var query = new Query();
            var queryExt = new QueryExtensionMethods();

            query.QueryOne();
            queryExt.QueryOneDotone();

            query.QueryTwo();
            queryExt.QueryTwoDotOne();

            query.QueryThree();
            queryExt.QueryThreeDotOne();

            queryExt.QueryFour();
            queryExt.QueryFive();
            queryExt.QuerySix();

        }
    }
}
