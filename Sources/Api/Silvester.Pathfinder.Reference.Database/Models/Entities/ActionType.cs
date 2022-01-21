using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class ActionType : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Spell> Spells { get; set; } = new List<Spell>();
        
        public ICollection<Feat> Feats { get; set; } = new List<Feat>();
     
        public ICollection<Action> Actions{ get; set; } = new List<Action>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class ActionTypeConfigurator : EntityConfigurator<ActionType>
	{
		public ActionTypeConfigurator()
		{
			ConfigureEntitySearch<ActionType>(e => new {e.Name});
		}
	}
}
