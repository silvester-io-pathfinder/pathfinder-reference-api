using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models
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

        public Guid AdvancedDeedId { get; set; }
        public Feat AdvancedDeed { get; set; } = default!;

        public Guid GreaterDeedId { get; set; }
        public Feat GreaterDeed { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
        
        public ICollection<GunslingersWayEffectBinding> Effects { get; set; } = new List<GunslingersWayEffectBinding>();
        
        public ICollection<GunslingersWayPrerequisiteBinding> Prerequisites { get; set; } = new List<GunslingersWayPrerequisiteBinding>();
        
        public ICollection<Skill> WaySkillIdOptions { get; set; } = new List<Skill>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
