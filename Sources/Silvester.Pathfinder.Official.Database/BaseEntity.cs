using NpgsqlTypes;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

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
}
