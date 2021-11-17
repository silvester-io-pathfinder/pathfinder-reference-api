using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class MeleeWeapon : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public int Price { get; set; }

        public int? Level { get; set; }

        public string Damage { get; set; } = default!;

        public string Hands { get; set; } = default!;

        public Guid DamageTypeId { get; set; }
        public DamageType DamageType { get; set; } = default!;

        public Guid? BulkId { get; set; }
        public Bulk? Bulk { get; set; } = default!;

        public Guid WeaponGroupId { get; set; }
        public WeaponGroup WeaponGroup { get; set; } = default!;

        public Guid WeaponCategoryId { get; set; }
        public WeaponCategory WeaponCategory { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();
        public ICollection<Deity> Deities { get; set; } = new List<Deity>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class MeleeWeaponSearchConfigurator : SearchableEntityConfigurator<MeleeWeapon>
    {
        public override Expression<Func<MeleeWeapon, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Damage, e.Description, e.Hands };
        }
    }
}
