using NpgsqlTypes;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;


namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Proficiency : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public int Bonus { get; set; }
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class ProficiencyConfigurator : EntityConfigurator<Proficiency>
	{
		public ProficiencyConfigurator()
		{
			ConfigureEntitySearch<Proficiency>(e => new {e.Name});
		}
	}
}
