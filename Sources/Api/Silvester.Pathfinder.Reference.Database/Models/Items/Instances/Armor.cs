using System;
using System.Linq.Expressions;
using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Items.Instances
{
    public class Armor : BaseItem
    {
        public Guid ArmorCategoryId { get; set; }
        public ArmorCategory ArmorCategory { get; set; } = default!;

        public Guid ArmorGroupId { get; set; }
        public ArmorGroup ArmorGroup { get; set; } = default!;
    }

    public class ArmorVariant : BaseItemVariant, ISearchableEntity
    {
        public int Price { get; set; }
        public int Level { get; set; }
        public int ArmorClassBonus { get; set; }
        public int DexterityCap { get; set; }
        public int CheckPenalty { get; set; }
        public int SpeedPenalty { get; set; }
        public int RequiredStrength { get; set; }

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class ArmorVariantConfigurator : EntityConfigurator<ArmorVariant>
	{
		public ArmorVariantConfigurator()
		{
			ConfigureEntitySearch<ArmorVariant>(e => new {e.Name});
		}
	}
}
