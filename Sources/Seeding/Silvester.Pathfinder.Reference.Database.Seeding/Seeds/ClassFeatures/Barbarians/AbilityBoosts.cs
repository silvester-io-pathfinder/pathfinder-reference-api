using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Barbarians
{
    public class AbilityBoosts : Template
    {
        public static readonly Guid ID = Guid.Parse("ad2005a6-e350-4160-99f1-d19c3d461338");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 5,
                Name = "Ability Boosts", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("3b109659-a960-41e6-a1c4-acd0b46005bb"), Type = TextBlockType.Text, Text = "At 5th level and every 5 levels thereafter, you boost four different ability scores. You can use these ability boosts to increase your ability scores above 18. Boosting an ability score increases it by 1 if it's already 18 or above, or by 2 if it starts out below 18." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAbilityBoost(Guid.Parse("9e2552eb-a9a3-45dd-9419-7946e76a587c"), Guid.Parse("5fb5b5ac-c8ea-451b-83aa-83c4fa29fd09"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("38aeeee9-a0e6-422a-9146-e123405e6604"), Guid.Parse("ba4bfbb0-0fda-4dd5-b81d-2d19a5d055dd"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("08fc0751-cf93-4e97-8eb8-99ac7411bccf"), Guid.Parse("4c55cd79-9309-4139-b894-7be3b4214844"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("5e8a7c89-f2fb-4ae7-9363-9050b61e672a"), Guid.Parse("bcb5cac7-c387-4425-9da2-202cadd2809c"), requiredLevel: 5);

            builder.GainAnyAbilityBoost(Guid.Parse("552ec7a8-b8c5-459a-9f1f-e3d995d48c65"), Guid.Parse("dec98048-6d59-4794-b331-1c5fb7942b47"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("3b6bec50-a5d6-49f1-bdbe-f12a1c960784"), Guid.Parse("7a562ef0-3450-459a-ae84-8305c01cf0e0"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("90c5f3d7-e196-4d15-8349-6ce2720ed72b"), Guid.Parse("a6f2e4e1-6de0-4ec8-a003-bf939cd14373"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("b8015394-3609-4d7d-8895-27912049c8c4"), Guid.Parse("098a489d-3c1d-43e4-8b8f-2a1cf5c722d3"), requiredLevel: 10);

            builder.GainAnyAbilityBoost(Guid.Parse("c8b7d245-707e-4eae-831d-53175d86b6fa"), Guid.Parse("ca51e0fe-3cb6-4420-b9a3-8cc8ee0566eb"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("f2bcce20-57d2-46fb-a6e9-a9065580e9c4"), Guid.Parse("ebe6b1a7-2351-4c1e-83b8-2e311b12e204"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("168ee980-03b8-4c76-850b-9909889bf773"), Guid.Parse("6e66b043-4307-4bcc-8c4c-f45f65d4613e"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("981c8e9d-2c05-4dde-bfc9-4611710054a3"), Guid.Parse("76ef2ef1-65f8-4b32-9b04-e2f9a1a43ceb"), requiredLevel: 15);

            builder.GainAnyAbilityBoost(Guid.Parse("6615f787-a960-493b-a1e5-2c84418219d8"), Guid.Parse("434b9d4f-c6da-4458-8668-3db841273bcc"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("24fcaf82-0ba8-449f-85fb-87be424a9246"), Guid.Parse("9af415ee-e088-4c7d-8355-dfd9b5913613"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("7506ac13-a996-4a32-95aa-60b1994864d0"), Guid.Parse("a71c3cc4-96d7-4383-97f8-067bd397660f"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("10058e2c-70a6-478e-8d42-66c0b1ad061b"), Guid.Parse("381e1c29-37c2-45a7-b571-e4e221189e1e"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("61f4f0c0-97e6-4b1f-abea-8e976f20e7cf"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 84
            };
        }
    }
}
