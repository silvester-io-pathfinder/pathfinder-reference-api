using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public interface IEntitySeeder<T>
        where T : class
    {
        IEnumerable<T> GetSeedEntities();
    }

    public interface IEntityJoiner<TSource, TTarget>
        where TSource : class
        where TTarget : class
    {
        public TTarget[] Join(TSource source, TTarget[] targets);
    }

    public interface IEntityJoiner<TSource, TTarget, TJoin>
        where TSource : class
        where TTarget : class
        where TJoin : class
    {
        public TJoin[] Join(TSource source, TTarget[] targets);
    }
}