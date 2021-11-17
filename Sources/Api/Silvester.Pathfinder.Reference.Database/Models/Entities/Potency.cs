using NpgsqlTypes;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;


namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Potency : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public int Order { get; set; }

        public ICollection<AlchemicalBombPotencyBinding> AlchemicalBombs { get; set; } = new List<AlchemicalBombPotencyBinding>();
        public ICollection<AlchemicalToolPotencyBinding> AlchemicalTools { get; set; } = new List<AlchemicalToolPotencyBinding>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class PotencySearchConfigurator : SearchableEntityConfigurator<Potency>
    {
        public override Expression<Func<Potency, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
