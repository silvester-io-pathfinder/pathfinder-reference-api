using NpgsqlTypes;
using Silvester.Pathfinder.Official.Database.Seeding;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public interface IRollableEffect
    {
        public string? CriticalSuccess { get; set; }

        public string? Success { get; set; }

        public string? Failure { get; set; }

        public string? CriticalFailure { get; set; }
    }

    public class RollableEffect : BaseEntity, IRollableEffect, ISearchableEntity
    {
        public Guid OwnerId { get; set; }
       
        public string? Name { get; set; }

        public string? CriticalSuccess { get; set; }

        public string? Success { get; set; } 

        public string? Failure { get; set; } 

        public string? CriticalFailure { get; set; }
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class RollableEffectSearchConfigurator : SearchableEntityConfigurator<RollableEffect>
    {
        public override Expression<Func<RollableEffect, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.CriticalFailure, e.CriticalSuccess, e.Failure, e.Success };
        }
    }
}
