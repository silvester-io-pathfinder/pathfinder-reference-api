using NpgsqlTypes;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Silvester.Pathfinder.Reference.Database
{
    public abstract class BaseEntity
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
