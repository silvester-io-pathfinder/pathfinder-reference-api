using NpgsqlTypes;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Domain : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public ICollection<Deity> Deities { get; set; } = new List<Deity>();

        public ICollection<Mystery> Mysteries { get; set; } = new List<Mystery>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class DomainConfigurator : EntityConfigurator<Domain>
	{
		public DomainConfigurator()
		{
			ConfigureEntitySearch<Domain>(e => new {e.Name, e.Description});
		}
	}
}
