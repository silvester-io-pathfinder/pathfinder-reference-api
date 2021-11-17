using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class PreciousMaterialWeapon : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public Guid MaterialId { get; set; }
        public PreciousMaterial Material { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();

        public ICollection<PreciousMaterialWeaponVariant> Variants { get; set; } = new List<PreciousMaterialWeaponVariant>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class PreciousMaterialWeaponVariant : BaseEntity
    {
        public string CraftRequirements { get; set; } = default!;

        public int ItemLevel { get; set; }

        public int Price { get; set; }

        public int AdditionalPricePerBulk { get; set; }

        public Guid WeaponId { get; set; }
        public PreciousMaterialWeapon Weapon { get; set; } = default!;

        public Guid GradeId { get; set; }
        public ItemGrade Grade { get; set; } = default!;
    }

    public class PreciousMaterialWeaponSearchConfigurator : SearchableEntityConfigurator<PreciousMaterialWeapon>
    {
        public override Expression<Func<PreciousMaterialWeapon, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
 