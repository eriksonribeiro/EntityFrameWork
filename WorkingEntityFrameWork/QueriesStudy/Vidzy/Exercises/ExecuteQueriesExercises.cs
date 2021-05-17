namespace Vidzy
{
    public static  class ExecuteQueriesExercises
     {

        public static void Exercise6()
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

        public static void Exercise7()
        {
            var q = new LazyEagerExplictLoading();
            q.LazyLoading();
            q.EagerLoading();
            q.ExplictLoading();
        }
     }
}
