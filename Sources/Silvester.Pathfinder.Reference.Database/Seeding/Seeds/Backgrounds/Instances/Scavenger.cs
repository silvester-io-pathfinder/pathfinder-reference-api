using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("d35071c7-b31b-440e-bc25-a2d650ae180a"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("e70bbd41-8d53-4fac-b156-3e6d1a3ffedf"), StatId = Stats.Instances.Intelligence.ID },
                    new StatEffectBinding{Id = Guid.Parse("c4705fb4-2b09-48c7-8ebb-0cb1a27e341f"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("2bc71572-cb16-48d8-a5e6-26fab4205cb6")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("4fa088fe-3a94-4f6d-892b-e4607af8e1c9"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Survival.ID
            };

            yield return new LoreCategoryEffect
            {
                Id = Guid.Parse("12271ea9-4f7a-43a8-895b-6754ec61cc7b"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreCategoryId = LoreCategories.Instances.Settlements.ID,
                Restrictions = "The chosen Lore skill must be related to the settlement you grew up sca"
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("8f1e7129-c527-45f1-9de2-5378113ee6c1"),
                FeatId = Feats.General.ForagerFeat.ID
            };
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
