using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class Aasimar : Template
    {
        public static readonly Guid ID = Guid.Parse("552b3bc3-c40c-42b6-a13b-436ba14e7c1e");

        protected override Heritage GetHeritage()
        {
           return new Heritage 
           {
               Id = ID, 
               RarityId = Rarities.Instances.Uncommon.ID, 
               Name = "Aasimar"
           };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You descend from celestials or were touched by the celestial realms, gaining an air of awe and grace, as well as features distinctive to your celestial forebears. You gain the aasimar trait, in addition to the traits from your ancestry. You also gain low-light vision, or you gain darkvision if your ancestry already has low-light vision. You can choose from aasimar feats and feats from your ancestry whenever you gain an ancestry feat." };    
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificTrait(Guid.Parse(""), Traits.Instances.Aasimar.ID);
            builder.AddOr(Guid.Parse(""), or =>
            {
                builder.GainSpecificSense(Guid.Parse(""), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
                builder.GainSpecificSense(Guid.Parse(""), Senses.Instances.Darkvision.ID, SenseAccuracies.Instances.Precise.ID)
                    .AddPrerequisites(Guid.Parse(""), prerequisites => 
                    {
                        prerequisites.HaveSpecificSense(Guid.Parse(""), Senses.Instances.LowLightVision.ID);
                    });
            });
            builder.UnlockSpecificTraitAncestryFeats(Guid.Parse(""), Traits.Instances.Aasimar.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 34
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Catfolk.ID;
            yield return Gnome.ID;
            yield return Goblin.ID;
            yield return Human.ID;
            yield return Tengu.ID;
            yield return Orc.ID;
            yield return Dwarf.ID;
            yield return Kobold.ID;
            yield return Ratfolk.ID;
            yield return Elf.ID;
            yield return Halfling.ID;
        }
    }
}
