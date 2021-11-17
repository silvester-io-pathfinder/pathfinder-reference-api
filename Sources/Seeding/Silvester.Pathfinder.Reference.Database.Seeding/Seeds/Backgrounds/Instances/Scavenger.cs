using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Scavenger : Template
    {
        public static readonly Guid ID = Guid.Parse("d890cb13-be63-4b5d-98ce-96321be3b8eb");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Scavenger",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("60ff3c80-39c5-46b5-b7bc-86513f2dac51"), Type = TextBlockType.Text, Text = "You've made a living sorting through the things society throws away. You might have scavenged simply to survive, or plied a trade as a ragpicker, dung carter, or the like. While you've left that life behind, you still keep one eye on the ground out of habit." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("6559c0ce-4074-43ec-962e-e1655295a3eb"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("8259b2bc-3ae1-4502-b6d2-e5ea7e0b32fb"), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("fc15845a-a193-4a75-a511-60cf2a90f3c8"), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("00cd7418-4016-44e7-94db-7c9a6a66dfcd"));
            builder.GainSpecificSkillProficiency(Guid.Parse("078aa0f8-7b89-45d1-83b2-d01138f62f00"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
            builder.GainSpecificLoreCategoryProficiency(Guid.Parse("5e9d6b76-2275-4c78-b1b8-82ecf4e2534d"), Proficiencies.Instances.Trained.ID, LoreCategories.Instances.Settlements.ID, "The chosen Lore skill must be related to the settlement you grew up scavenging in.");
            builder.GainSpecificFeat(Guid.Parse("b3a11836-179d-4631-a139-ffc2765d3d32"), Feats.Instances.Forager.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5c93f21b-2c32-425f-a3d8-eafdc08b02a5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 49
            };
        }
    }
}
