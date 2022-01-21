using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items.Abstractions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Models.Items.Instances
{
    public class Stave : BaseItem
    {

    }

    public class StaveVariant : BaseItemVariant, IHeld, IUsed, ISearchableEntity
    {
        public int Price { get; set; }
       
        public int Level { get; set; }

        public string Hands { get; set; } = default!;

        public string Usage { get; set; } = default!;

        public Guid PotencyId { get; set; }
        public Potency Potency { get; set; } = default!;

        public ICollection<StaveSpell> Spells { get; set; } = new List<StaveSpell>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class StaveVariantConfigurator : EntityConfigurator<StaveVariant>
	{
		public StaveVariantConfigurator()
		{
			ConfigureEntitySearch<StaveVariant>(e => new {e.Name, e.Usage});
		}
	}

    public class StaveSpell : BaseEntity
    {
        public int Level { get; set; }

        public Guid SpellId { get; set; }
        public Spell Spell { get; set; } = default!;
    }
}
