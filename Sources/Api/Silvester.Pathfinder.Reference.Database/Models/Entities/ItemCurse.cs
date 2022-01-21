using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class ItemCurse : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;
        public string Usage { get; set; } = default!;
        public int Level { get; set; }

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
        public ICollection<Trait> Traits { get; set; } = new List<Trait>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class ItemCurseConfigurator : EntityConfigurator<ItemCurse>
	{
		public ItemCurseConfigurator()
		{
			ConfigureEntitySearch<ItemCurse>(e => new {e.Name, e.Usage});
		}
	}
}
