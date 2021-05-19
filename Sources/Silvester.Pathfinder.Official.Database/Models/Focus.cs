using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Focus : BaseEntity
    {
        public string Name { get; set; } = default!;

        public int Level { get; set; }

        public string? Range { get; set; }
        
        public string? Area { get; set; }

        public string? Targets { get; set; }

        public string? CastTime { get; set; }

        public string? Trigger { get; set; }

        public string? Requirements { get; set; }

        public string? Duration { get; set; }

        public bool? IsSavingThrowBasic { get; set; }
        
        public bool IsDismissable { get; set; }

        public Guid? SavingThrowStatId { get; set; }
        public SavingThrowStat? SavingThrowStat { get; set; }

        public Guid? DomainId { get; set; }
        public Domain? Domain { get; set; }

        public Guid MagicSchoolId { get; set; }
        public MagicSchool MagicSchool { get; set; } = default!;

        public Guid FocusTypeId { get; set; }
        public FocusType FocusType { get; set; } = default!;

        public Guid ActionTypeId { get; set; }
        public ActionType ActionType { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid ClassId { get; set; }
        public Class Class { get; set; } = default!;

        public Guid? TableId  { get; set; }
        public ActionType? Table { get; set; } = default!;

        public Guid? RollableEffectId { get; set; }
        public RollableEffect? RollableEffect { get; set; }

        public ICollection<SpellComponent> Components { get; set; } = new List<SpellComponent>();
        public ICollection<FocusHeightening> Heightenings { get; set; } = new List<FocusHeightening>();
        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
    }

    public class FocusType : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;

        public ICollection<Focus> Focusses { get; set; } = new List<Focus>();
    }

    public class FocusHeightening : BaseEntity
    {
        public string Level { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();

        public Guid FocusId { get; set; }
        public Focus Focus { get; set; } = default!;
    }
}
