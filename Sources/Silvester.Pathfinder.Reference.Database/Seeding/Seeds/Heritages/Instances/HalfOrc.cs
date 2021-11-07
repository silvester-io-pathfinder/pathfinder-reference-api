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
    public class HalfOrc : Template
    {
        public static readonly Guid ID = Guid.Parse("b54692a4-5791-4971-9590-17889ca0cbaa");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Half-Orc"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "One of your parents was an orc, or one or both were half-orcs. You have a green tinge to your skin and other indicators of orc heritage. You gain the orc trait, the half-orc trait, and low-light vision. In addition, you can select orc, half-orc, and human feats whenever you gain an ancestry feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificTrait(Guid.Parse(""), Traits.Instances.Orc.ID);
            builder.GainSpecificTrait(Guid.Parse(""), Traits.Instances.HalfOrc.ID);
            builder.GainSpecificSense(Guid.Parse(""), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
            builder.UnlockSpecificTraitAncestryFeats(Guid.Parse(""), Traits.Instances.Orc.ID);
            builder.UnlockSpecificTraitAncestryFeats(Guid.Parse(""), Traits.Instances.HalfOrc.ID);
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
            yield return Orc.ID;
        }
    }
}
