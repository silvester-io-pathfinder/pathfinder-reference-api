using NpgsqlTypes;
using Silvester.Pathfinder.Official.Database.Utilities.Tables;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Mystery : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;
        
        public string? TrainedSkillAddendum { get; set; }

        public Guid MysteryCurseId { get; set; }
        public MysteryCurse MysteryCurse { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid TrainedSkillId { get; set; }
        public Skill TrainedSkill { get; set; } = default!;

        public Guid GrantedCantripId { get; set; }
        public Spell GrantedCantrip { get; set; } = default!;

        public Guid InitialRevelationId { get; set; }
        public Spell InitialRevelation { get; set; } = default!;

        public Guid AdvancedRevelationId { get; set; }
        public Spell AdvancedRevelation { get; set; } = default!;

        public Guid GreaterRevelationId { get; set; }
        public Spell GreaterRevelation { get; set; } = default!;
        
        public ICollection<Domain> RelatedDomains { get; set; } = new List<Domain>();
        
        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
        
        public ICollection<TextBlock> MysteryBenefits { get; set; } = new List<TextBlock>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class MysteryCurse : BaseEntity
    {
        public string Name { get; set; } = default!;

        public Guid MysteryId { get; set; }
        public Mystery Mystery { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;
        
        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
        public ICollection<MysteryCursePotency> Potencies { get; set; } = new List<MysteryCursePotency>();

        public Guid? TableId { get; set; }
        public Table? Table { get; set; } = default!;
    }

    public class MysteryCursePotency : BaseEntity
    {
        public Guid MysteryCurseId { get; set; }
        public MysteryCurse MysteryCurse { get; set; } = default!;

        public Guid PotencyId { get; set; }
        public Potency Potency { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
    }
}
