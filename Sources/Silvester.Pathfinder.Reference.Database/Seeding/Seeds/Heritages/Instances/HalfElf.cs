using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class HalfElf : Template
    {
        public static readonly Guid ID = Guid.Parse("a3b12707-a7f5-41f0-9f49-f41d1839d5f7");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Half-Elf"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Either one of your parents was an elf, or one or both were half-elves. You have pointed ears and other telltale signs of elf heritage. You gain the elf trait, the half-elf trait, and low-light vision. In addition, you can select elf, half-elf, and human feats whenever you gain an ancestry feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificTrait(Guid.Parse(""), Traits.Instances.Elf.ID);
            builder.GainSpecificTrait(Guid.Parse(""), Traits.Instances.HalfElf.ID);
            builder.GainSpecificSense(Guid.Parse(""), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
            builder.UnlockSpecificTraitAncestryFeats(Guid.Parse(""), Traits.Instances.Elf.ID);
            builder.UnlockSpecificTraitAncestryFeats(Guid.Parse(""), Traits.Instances.HalfElf.ID);
            builder.UnlockSpecificTraitAncestryFeats(Guid.Parse(""), Traits.Instances.Human.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 56
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Human.ID;
            yield return Elf.ID;
        }
    }
}
