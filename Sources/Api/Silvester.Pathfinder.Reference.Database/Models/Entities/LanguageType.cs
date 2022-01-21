using NpgsqlTypes;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class LanguageType : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Language> Languages { get; set; } = new List<Language>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class LanguageTypeConfigurator : EntityConfigurator<LanguageType>
	{
		public LanguageTypeConfigurator()
		{
			ConfigureEntitySearch<LanguageType>(e => new {e.Name});
		}
	}
}
