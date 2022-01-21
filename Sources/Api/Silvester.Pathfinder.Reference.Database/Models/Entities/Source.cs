using NpgsqlTypes;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Source : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;
        
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class SourceConfigurator : EntityConfigurator<Source>
	{
		public SourceConfigurator()
		{
			ConfigureEntitySearch<Source>(e => new {e.Name});
		}
	}
}
