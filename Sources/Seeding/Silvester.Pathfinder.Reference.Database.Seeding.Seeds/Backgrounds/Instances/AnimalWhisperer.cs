using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

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

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("0d990b80-e555-4ab9-9e87-f7f0e40749a4"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("dfafba6e-3ece-41bb-9840-3e0060c7d0b4"), Stats.Instances.Wisdom.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("7c93d214-5aa9-4a02-b77c-f42bc2f9bd64"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("5c3dca83-0695-4d78-bcf4-104799cff874"));
            builder.GainSpecificSkillProficiency(Guid.Parse("0d0fb4bb-b070-4c0e-8a8f-507f50d71643"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
            builder.GainSpecificLoreCategoryProficiency(Guid.Parse("1f3db2d2-c597-4d96-b79c-6590ee905299"), Proficiencies.Instances.Trained.ID, LoreCategories.Instances.Terrains.ID);
            builder.GainSpecificFeat(Guid.Parse("bdccf763-fb40-4278-9f2e-b412a727a758"), Feats.Instances.TrainAnimal.ID);
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
