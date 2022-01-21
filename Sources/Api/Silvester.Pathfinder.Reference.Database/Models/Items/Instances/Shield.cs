using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Items.Abstractions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Models.Items.Instances
{
    public class Shield : BaseItem
    {

    }

    public class ShieldVariant : BaseItemVariant, IHeld, IUsed, ISearchableEntity
    {
        public int Price { get; set; }
       
        public int ArmorClassBonus { get; set; }

        public int SpeedPenalty { get; set; }

        public int Hardness { get; set; }

        public int HitPoints { get; set; }

        public int BrokenThreshold { get; set; }

        public string Hands { get; set; } = default!;

        public string Usage { get; set; } = default!;

        public int Level { get; set; }

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class ShieldVariantConfigurator : EntityConfigurator<ShieldVariant>
	{
		public ShieldVariantConfigurator()
		{
			ConfigureEntitySearch<ShieldVariant>(e => new {e.Name, e.Usage});
		}
	}
}
