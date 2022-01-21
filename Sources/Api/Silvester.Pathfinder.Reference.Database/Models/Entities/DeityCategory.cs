using NpgsqlTypes;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;


namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class DeityCategory : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public ICollection<Deity> Deities { get; set; } = new List<Deity>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class DeityCategoryConfigurator : EntityConfigurator<DeityCategory>
	{
		public DeityCategoryConfigurator()
		{
			ConfigureEntitySearch<DeityCategory>(e => new {e.Name, e.Description});
		}
	}
}
