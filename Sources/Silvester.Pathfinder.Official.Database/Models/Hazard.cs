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

        public int ArmorClass { get; set; }

        public string? Reset { get; set; }

        public int? Hardness { get; set; }

        public int? BrokenThreshold { get; set; }

        public int HitPoints { get; set; }

        public int? Fortitude { get; set; }

        public int? Reflex { get; set; }

        public bool CanBeDetectedMagically { get; set; }

        public bool CanBeDetectedAtAll { get; set; }

        public Guid? AttackTypeId { get; set; }
        public AttackType? AttackType { get; set; }

        public Guid? DetectionRequirementId { get; set; }
        public HazardDetectionRequirement? DetectionRequirement { get; set; } 
        
        public Guid ComplexityId{ get; set; }
        public HazardComplexity Complexity { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid TypeId { get; set; }
        public HazardType Type { get; set; } = default!;

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();

        public ICollection<HazardImmunity> Immunities { get; set; } = new List<HazardImmunity>();

        public ICollection<HazardDisableRequirement> DisableRequirements { get; set; } = new List<HazardDisableRequirement>();
     
        public ICollection<HazardDispellRequirement> DispellRequirements { get; set; } = new List<HazardDispellRequirement>();
    }
}
