using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Items.Abstractions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Models.Items.Instances
{
    public class AdventuringGear : BaseItem
    {

    }

    public class AdventuringGearVariant : BaseItemVariant, IUsed, ISearchableEntity
    {
        public int Price { get; set; }
        public string? Hands { get; set; }
        public int Level { get; set; }
        public string Usage { get; set; } = default!;

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class AdventuringGearVariantConfigurator : EntityConfigurator<AdventuringGearVariant>
    {
        public AdventuringGearVariantConfigurator()
        {
            ConfigureEntitySearch<AdventuringGearVariant>(e => new { e.Name, e.Usage });
        }
    }
}
