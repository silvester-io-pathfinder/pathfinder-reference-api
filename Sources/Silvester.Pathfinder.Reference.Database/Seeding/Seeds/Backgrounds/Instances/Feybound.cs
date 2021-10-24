using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Feybound : Template
    {
        public static readonly Guid ID = Guid.Parse("c3eeb15a-5477-470c-845d-26346bb88b41");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Feybound",
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7f9664ec-f5a2-48e1-86fa-8602166eb0f1"), Type = TextBlockType.Text, Text = "You have spent time in the First World or another realm of the fey and aren't entirely the same person you were before. Perhaps you made a purchase at the legendary Witchmarket or partook deeply of fey food and wine. Whatever the case, willingly or inadvertently, you made a bargain with the fey, the benefits of which come at a price." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Dexterity.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse(""));
            builder.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.Fey.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.FeysFortune.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5f156471-74d1-4732-9bb1-d54d35b10b60"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 50
            };
        }
    }
}
