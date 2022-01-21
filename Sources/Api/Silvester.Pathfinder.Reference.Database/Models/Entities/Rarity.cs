using NpgsqlTypes;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;


namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Rarity : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Ancestry> Ancestries { get; set; } = new List<Ancestry>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class RarityConfigurator : EntityConfigurator<Rarity>
	{
		public RarityConfigurator()
		{
			ConfigureEntitySearch<Rarity>(e => new {e.Name});
		}
	}
}
