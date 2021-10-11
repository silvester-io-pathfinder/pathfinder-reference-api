using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    public class Feat : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public bool CanBeLearnedMoreThanOnce { get; set; }

        public string? Special {get;set;} = default!;

        public string? Trigger { get; set; } = default!;
        
        public string? Frequency { get; set; }

        public int Level { get; set; }

        public Guid ActionTypeId { get; set; }
        public ActionType ActionType { get; set; } = default!;

        public Guid FeatTypeId { get; set; }
        public FeatType FeatType { get; set; } = default!;

        public RollableEffect? RollableEffect { get; set; }
        public Guid? RollableEffectId { get; set; }

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();

        public ICollection<Prerequisite.FeatPrerequisiteBinding> Prerequisites { get; set; } = new List<Prerequisite.FeatPrerequisiteBinding>();

        public ICollection<FeatRequirement> Requirements { get; set; } = new List<FeatRequirement>();

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
        
        //GainProficiencyEffect(FarmingLore, Proficiency.Trained)
        //TriggerAtLevelEffect(3, GainProficiencyEffect(FarmingLore, Proficiency.Expert))
        //TriggerAtLevelEffect(7, GainProficiencyEffect(FarmingLore, Proficiency.Master))
        //TriggerAtLevelEffect(15, GainProficiencyEffect(FarmingLore, Proficiency.Legendary))
        //GainHeritage(HeritageRarity.Common, 1)
        //GainFeat(FeatType.Heritage, 1)
        //GainSpell("Detect Magic", Level 1)
        //GainNextArmorProficiency(Proficiency.Trained)
        //GainAssurance()

        //public ICollection<FeatEffect> Effects { get; set; } = new List<Prerequisite>();
    }
}
