using NpgsqlTypes;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;


namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class HazardComplexity : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Hazard> Hazards { get; set; } = new List<Hazard>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class HazardComplexityConfigurator : EntityConfigurator<HazardComplexity>
	{
		public HazardComplexityConfigurator()
		{
			ConfigureEntitySearch<HazardComplexity>(e => new {e.Name});
		}
	}
}
