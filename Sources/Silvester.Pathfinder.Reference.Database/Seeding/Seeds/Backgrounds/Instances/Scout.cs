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
    public class Scout : Template
    {
        public static readonly Guid ID = Guid.Parse("a6116a94-0555-4882-969e-c7b245e2b6b3");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Scout",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7ea32318-8408-4144-95fd-8b852ad3d83b"), Type = TextBlockType.Text, Text = "You called the wilderness home as you found trails and guided travelers. Your wanderlust could have called you to the adventuring life, or perhaps you served as a scout for soldiers and found you liked battle." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Dexterity.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse(""));
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
            builder.GainSpecificLoreCategoryProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, LoreCategories.Instances.Terrains.ID, "The chosen Lore skill must relate to a terrain you scouted in (such as Forest Lore or Cavern Lore).");
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.Forager.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9cd0aeea-0c78-4124-b30b-eb06751d37b3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 64
            };
        }
    }
}
