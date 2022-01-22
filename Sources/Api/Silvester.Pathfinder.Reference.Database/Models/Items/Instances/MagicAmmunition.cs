using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;
using System.Linq.Expressions;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Models.Items.Instances
{
    public class MagicAmmunition : BaseItem, INamedEntity
    {
        public ICollection<Ammunition> CraftableAs { get; set; } = new List<Ammunition>();
    }

    public class MagicAmmunitionVariant : BaseItemVariant, ISearchableEntity
    {
        public int Price { get; set; }
        public int Level { get; set; }

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class MagicAmmunitionVariantConfigurator : EntityConfigurator<MagicAmmunitionVariant>
    {
        public MagicAmmunitionVariantConfigurator()
        {
            ConfigureEntitySearch<MagicAmmunitionVariant>(e => new { e.Name });
        }
    }
}
