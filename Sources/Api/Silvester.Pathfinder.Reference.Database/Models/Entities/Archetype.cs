using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Seeding;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Archetype : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public bool IsMulticlassArchetype { get; set; }

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;
        
        public Guid DedicationFeatId { get; set; }
        public Feat DedicationFeat { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
        public ICollection<TextBlock> MulticlassDetails { get; set; } = new List<TextBlock>();
        public ICollection<Feat> Feats { get; set; } = new List<Feat>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class ArchetypeConfigurator : EntityConfigurator<Archetype>
	{
		public ArchetypeConfigurator()
		{
			ConfigureEntitySearch<Archetype>(e => new {e.Name});
		}
	}
}
