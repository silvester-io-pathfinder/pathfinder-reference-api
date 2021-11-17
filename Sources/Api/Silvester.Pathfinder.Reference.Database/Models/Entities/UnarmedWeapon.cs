using NpgsqlTypes;
using System.Collections.Generic;
using System;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class UnarmedWeapon : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Deity> Deities { get; set; } = new List<Deity>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class UnarmedWeaponSearchConfigurator : SearchableEntityConfigurator<UnarmedWeapon>
    {
        public override Expression<Func<UnarmedWeapon, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
