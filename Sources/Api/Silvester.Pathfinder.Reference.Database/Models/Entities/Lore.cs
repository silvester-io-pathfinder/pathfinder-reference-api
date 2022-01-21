using NpgsqlTypes;
using System;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Lore : BaseEntity, ISearchableEntity, INamedEntity
    {
        public virtual string Name { get; set; } = default!;

        public Guid StatModifierId { get; set; }
        public Stat StatModifier { get; set; } = default!;
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class LoreConfigurator : EntityConfigurator<Lore>
	{
		public LoreConfigurator()
		{
			ConfigureEntitySearch<Lore>(e => new {e.Name});
		}
	}
}
