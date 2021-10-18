using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class AnimalWhisperer : Template
    {
        public static readonly Guid ID = Guid.Parse("bab65274-cb3a-4b33-b119-aad76c16d076");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Animal Whisperer",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4f497a23-b8e5-42c6-83ed-d39efa2e8069"), Type = TextBlockType.Text, Text = "You have always felt a connection to animals, and it was only a small leap to learn to train them. As you travel, you continuously encounter different creatures, befriending them along the way." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificAbilityBoostEffect
            {
                Id = Guid.Parse("8d9c2420-672a-40bd-b809-cd5ed641207b"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("20044534-3b18-4228-95fe-a4b4ce8a980d"), StatId = Stats.Instances.Wisdom.ID },
                    new StatEffectBinding{Id = Guid.Parse("abd3f352-9b4a-4900-9f6e-3843395f9368"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new GainAnyAbilityBoostEffect
            {
                Id = Guid.Parse("ff9c4fc7-a9ef-465e-b0f3-631276d50e7d")
            };

            yield return new GainSpecificSkillProficiencyEffect
            {
                Id = Guid.Parse("120d6ded-3b91-4bb8-a601-a8159f017b53"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Nature.ID
            };

            yield return new GainSpecificLoreCategoryProficiencyEffect
            {
                Id = Guid.Parse("e8892b2d-c07c-4176-bd54-8c98829ac081"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreCategoryId = LoreCategories.Instances.Terrains.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse("a1dc6921-b401-4dd6-a23d-6e62af251c8a"),
                FeatId = Feats.General.TrainAnimalFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d5fa4df2-a7c6-43de-8db2-6b2329a3a784"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 60
            };
        }
    }
}
