using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    //Parent types.
    public abstract class FeatEffect : BaseEntity
    {
        public Guid BindingId { get; set; }
        public BaseFeatEffectBinding Binding { get; set; } = default!;

        public int? TriggeredAtLevel { get; set; }

        public abstract class BaseFeatEffectBinding : BaseEntity
        {

        }

        public class FeatEffectBinding : BaseFeatEffectBinding
        {
            public Guid FeatId { get; set; }
            public Feat Feat { get; set; } = default!;
        }

        public class OrEffectBinding : BaseFeatEffectBinding
        {
            public Guid OrFeatEffectId { get; set; }
            public OrFeatEffect OrFeatEffect { get; set; } = default!;
        }
    }

    public class OrFeatEffect : FeatEffect
    {
        public ICollection<FeatEffect> Choices { get; set; } = new List<FeatEffect>();
    }

   
    public class GainHeritageEffect : FeatEffect
    {
        public Guid HeritageRarityId { get; set; }
        public Rarity HeritageRarity { get; set; } = default!;
    }

    public class GainLoreEffect : FeatEffect
    {
        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;
    }
    
    public class GainHeritageFeatEffect : FeatEffect
    {
        public int Level { get; set; }
    }
}
