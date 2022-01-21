using NpgsqlTypes;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;


namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class MagicEssence : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class MagicEssenceConfigurator : EntityConfigurator<MagicEssence>
	{
		public MagicEssenceConfigurator()
		{
			ConfigureEntitySearch<MagicEssence>(e => new {e.Name, e.Description});
		}
	}
}
