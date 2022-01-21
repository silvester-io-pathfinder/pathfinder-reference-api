using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Muse : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid? EffectId { get; set; }
        public BooleanEffect? Effect { get; set; }

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class MuseConfigurator : EntityConfigurator<Muse>
	{
		public MuseConfigurator()
		{
			ConfigureEntitySearch<Muse>(e => new {e.Name, e.Description});
		}
	}
}
