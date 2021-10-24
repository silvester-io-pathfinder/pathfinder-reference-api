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
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse(""));
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
            builder.GainSpecificLoreCategoryProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, LoreCategories.Instances.Settlements.ID, "The chosen Lore skill must be related to the settlement you grew up scavenging in.");
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.Forager.ID);
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
