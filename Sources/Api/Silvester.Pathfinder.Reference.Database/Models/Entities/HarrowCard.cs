using NpgsqlTypes;
using System;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class HarrowCard : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!; 

        public Guid AlignmentId { get; set; }
        public Alignment Alignment { get; set; } = default!;

        public Guid HarrowCategoryId { get; set; }
        public HarrowCategory HarrowCategory { get; set; } = default!;

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class HarrowCardConfigurator : EntityConfigurator<HarrowCard>
	{
		public HarrowCardConfigurator()
		{
			ConfigureEntitySearch<HarrowCard>(e => new {e.Name, e.Description});
		}
	}
}
