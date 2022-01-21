using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;

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
