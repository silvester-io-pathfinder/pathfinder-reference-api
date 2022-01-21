using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;


namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class GunslingersWay : BaseEntity, INamedEntity, ISearchableEntity
    {
        public string Name { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid SlingersReloadId { get; set; }
        public Feat SlingersReload { get; set; } = default!;

        public Guid InitialDeedId { get; set; }
        public Feat InitialDeed { get; set; } = default!;

        public Guid? EffectId { get; set; }
        public BooleanEffect? Effect{ get; set; } 

        public Guid? PrerequisiteId { get; set; }
        public BooleanPrerequisite? Prerequisite { get; set; }

        public Guid AdvancedDeedId { get; set; }
        public Feat AdvancedDeed { get; set; } = default!;

        public Guid GreaterDeedId { get; set; }
        public Feat GreaterDeed { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
        
        public ICollection<Skill> WaySkillIdOptions { get; set; } = new List<Skill>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class GunslingersWayConfigurator : EntityConfigurator<GunslingersWay>
	{
		public GunslingersWayConfigurator()
		{
			ConfigureEntitySearch<GunslingersWay>(e => new {e.Name});
		}
	}
}
