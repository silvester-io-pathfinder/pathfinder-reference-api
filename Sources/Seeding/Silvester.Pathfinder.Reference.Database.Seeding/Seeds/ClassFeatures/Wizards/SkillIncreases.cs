using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Wizards
{
    public class SkillIncreases : Template
    {
        public static readonly Guid ID = Guid.Parse("70f67cd9-c4ed-4979-a041-f630b3a27650");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 3,
                Name = "Skill Increases", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("73908ae3-8583-427f-b420-c668ff8519fe"), Type = TextBlockType.Text, Text = "At 3rd level and every 2 levels thereafter, you gain a skill increase. You can use this skill increase to become trained in one skill you're untrained in, or become an expert in one skill in which you are already trained." };
            yield return new TextBlock { Id = Guid.Parse("845300a1-6bdc-4417-8af3-7b8f9a11e40a"), Type = TextBlockType.Text, Text = "At 7th level, you can use skill increases to become a master in a skill in which you're already an expert, and at 15th level, you can use them to become legendary in a skill in which you're already a master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSkillIncrease(Guid.Parse("5a2e177d-c067-477d-ab2a-6d21e35add13"), Guid.Parse("fd78e0c4-9934-47f8-a9ab-64f3875fda85"), requiredLevel: 3);
            builder.GainSkillIncrease(Guid.Parse("f11fd71d-a26f-485d-acc5-d45a0c80ddc0"), Guid.Parse("80032ebd-eff8-47a4-9f81-6145a278436d"), requiredLevel: 5);
            builder.GainSkillIncrease(Guid.Parse("7ae7c2a1-8dc8-4841-b2cf-cc4c996bebf0"), Guid.Parse("25636289-1bc6-4ceb-b144-ed35e25d92ac"), requiredLevel: 7);
            builder.GainSkillIncrease(Guid.Parse("6e97e2d6-53df-41b2-b8b0-5c71ed0f834b"), Guid.Parse("6d0043eb-7771-4cf1-ba81-59f7f67d1a0c"), requiredLevel: 9);
            builder.GainSkillIncrease(Guid.Parse("b3c13d2f-778c-4652-9829-6ab9779695b1"), Guid.Parse("25dfb229-4db9-4b17-a5a6-5ba0688056fb"), requiredLevel: 11);
            builder.GainSkillIncrease(Guid.Parse("9c6ab17e-f752-4094-8278-de726aa1ac0b"), Guid.Parse("ae48fc2f-9777-4ea5-800b-8133aab3b913"), requiredLevel: 13);
            builder.GainSkillIncrease(Guid.Parse("2a58bc21-84d0-459e-92a0-955348649000"), Guid.Parse("119f3a5d-b867-4486-b989-f1b3afbf2d6b"), requiredLevel: 15);
            builder.GainSkillIncrease(Guid.Parse("2366611c-6113-47b6-a68b-bd1f4fe37196"), Guid.Parse("2d17968b-7d41-49d9-acf5-1145b2f94d7f"), requiredLevel: 17);
            builder.GainSkillIncrease(Guid.Parse("1c2c55f3-7580-48c9-aa66-4fa19818fa0b"), Guid.Parse("66569ba5-c66f-482c-b7ee-8a38adc97162"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8af200c5-ab16-44a2-9be8-5ee4119be10a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 206
            };
        }
    }
}
