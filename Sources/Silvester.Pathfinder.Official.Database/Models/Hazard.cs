using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Hazard : BaseEntity
    {
        public string Name { get; set; } = default!;

        public int Level { get; set; }
        
        public string Description { get; set; } = default!;

        public int? ArmorClass { get; set; }

        public string? Reset { get; set; }

        public int? Speed { get; set; }

        public int? Fortitude { get; set; }

        public int? Reflex { get; set; }

        public int? RoutineActions { get; set; }

        public bool CanBeDetectedMagically { get; set; }

        public Guid ComplexityId{ get; set; }
        public HazardComplexity Complexity { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid TypeId { get; set; }
        public HazardType Type { get; set; } = default!;

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();

        public ICollection<HazardComponent> HazardComponents { get; set; } = new List<HazardComponent>();

        public ICollection<HazardImmunity> Immunities { get; set; } = new List<HazardImmunity>();

        public ICollection<HazardDisableRequirement> DisableRequirements { get; set; } = new List<HazardDisableRequirement>();
     
        public ICollection<HazardDispellRequirement> DispellRequirements { get; set; } = new List<HazardDispellRequirement>();
            
        public ICollection<HazardAction> Actions{ get; set; } = new List<HazardAction>();
     
        public ICollection<HazardRoutineDetailBlock> RoutineDetails { get; set; } = new List<HazardRoutineDetailBlock>();
    }

    public enum HazardRoutineDetailBlockType
    {
        Text,
        Enumeration
    }

    public class HazardRoutineDetailBlock : BaseEntity
    {
        public Guid HazardId { get; set; }
        public Hazard Hazard { get; set; } = default!;

        public string Text { get; set; } = default!;
        public HazardRoutineDetailBlockType Type { get; set; }
    }
}
