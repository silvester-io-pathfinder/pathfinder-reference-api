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
            yield return new TextBlock { Id = Guid.Parse("e131c4c9-cbd8-4c88-98e8-64ab2c66fb7c"), Type = TextBlockType.Text, Text = "One of your parents was an orc, or one or both were half-orcs. You have a green tinge to your skin and other indicators of orc heritage. You gain the orc trait, the half-orc trait, and low-light vision. In addition, you can select orc, half-orc, and human feats whenever you gain an ancestry feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificTrait(Guid.Parse("b485d96d-da4d-4966-84ef-afafed7ac50c"), Traits.Instances.Orc.ID);
            builder.GainSpecificTrait(Guid.Parse("144bfbd0-9b4d-46ca-af7e-c75c170f1219"), Traits.Instances.HalfOrc.ID);
            builder.GainSpecificSense(Guid.Parse("e1020d59-d383-4812-9003-14496fe6a34c"), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
            builder.UnlockSpecificTraitAncestryFeats(Guid.Parse("98f57684-2283-4d7d-9675-27eb4d57654e"), Traits.Instances.Orc.ID);
            builder.UnlockSpecificTraitAncestryFeats(Guid.Parse("4a241f4f-89ac-437c-bc53-75d38c8477cb"), Traits.Instances.HalfOrc.ID);
            builder.UnlockSpecificTraitAncestryFeats(Guid.Parse("88a92400-0571-4b1a-a610-01bfb83c6573"), Traits.Instances.Human.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("27e328f8-4085-4cff-8148-60c444f26043"),
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
