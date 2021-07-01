using NpgsqlTypes;
using System;

namespace Silvester.Pathfinder.Official.Database
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
    }

    public interface IOwnedEntity
    {
        Guid OwnerId { get; set; }
    }

    public interface ISearchableEntity
    {
        NpgsqlTsVector SearchVector { get; set; }
    }

    public interface INamedEntity
    {
        string Name { get; set; }
    }
}
