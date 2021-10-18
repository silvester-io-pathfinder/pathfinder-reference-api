using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificAbilityBoostEffect
            {
                Id = Guid.Parse("e335a370-a8d6-4bae-8d8b-59659dc2527e"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("af900c24-f587-41ba-8cb1-3ac87b39dbe4"), StatId = Stats.Instances.Dexterity.ID },
                    new StatEffectBinding{Id = Guid.Parse("e87cb1c5-7e09-403c-8e79-f13e9d4506cf"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new GainAnyAbilityBoostEffect
            {
                Id = Guid.Parse("96771da7-eabb-455a-8794-28f1b9335002")
            };

            yield return new GainSpecificLoreProficiencyEffect
            {
                Id = Guid.Parse("8f1e821e-5e8b-4ef2-ae6f-73be8203a4cc"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Fey.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse("8f3cce7c-b10a-421f-be5e-0d71b147cb35"),
                FeatId = Feats.Special.FeysFortuneFeat.ID
            };
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
