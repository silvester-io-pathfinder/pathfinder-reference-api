using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public interface IEntitySeed<T>
        where T : class
    {
        IEnumerable<T> GetSeedEntities();
    }

    public interface IEntityJoin<TSource, TTarget>
        where TSource : class
        where TTarget : class
    {
        public TTarget[] Join(TSource source, TTarget[] targets);
    }

    public interface IEntityJoin<TSource, TTarget, TJoin>
        where TSource : class
        where TTarget : class
        where TJoin : class
    {
        public TJoin[] Join(TSource source, TTarget[] targets);
    }
}