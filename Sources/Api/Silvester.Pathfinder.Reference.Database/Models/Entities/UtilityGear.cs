using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Seeding;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class UtilityGear : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string? Usage { get; set; }

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();

        public ICollection<UtilityGearVariant> Variants { get; set; } = new List<UtilityGearVariant>();

        public ICollection<InlineAction> InlineActions { get; set; } = new List<InlineAction>();

        public ICollection<UtilityGearTraitBinding> TraitBindings { get; set; } = new List<UtilityGearTraitBinding>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class UtilityGearConfigurator : EntityConfigurator<UtilityGear>
	{
		public UtilityGearConfigurator()
		{
			ConfigureEntitySearch<UtilityGear>(e => new {e.Name, e.Usage});
		}
	}

    public class UtilityGearTraitBinding : TraitBinding<UtilityGear>
    {

    }

    public class UtilityGearVariant : BaseEntity
    {
        public string Name { get; set; } = default!;

        public int ItemLevel { get; set; }

        public int Price { get; set; }

        public ICollection<TextBlock> Addendum { get; set; } = new List<TextBlock>();

        public Guid BulkId { get; set; }
        public Bulk Bulk { get; set; } = default!;

        public Guid RarityId { get; set; }
        public Rarity Rarity { get; set; } = default!;

        public Guid UtilityGearId { get; set; }
        public UtilityGear UtilityGear { get; set; } = default!;
    }
}
