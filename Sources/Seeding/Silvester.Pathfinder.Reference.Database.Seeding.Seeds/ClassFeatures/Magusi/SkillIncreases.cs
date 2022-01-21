using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Magusi
{
    public class SkillIncreases : Template
    {
        public static readonly Guid ID = Guid.Parse("8e357b1b-c46b-4892-8042-49f0af29f214");

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
            yield return new TextBlock { Id = Guid.Parse("f794986f-76b9-4ce7-b628-c60b52c90169"), Type = TextBlockType.Text, Text = "At 3rd level and every 2 levels thereafter, you gain a skill increase. You can use this skill increase to become trained in one skill you're untrained in, or become an expert in one skill in which you are already trained." };
            yield return new TextBlock { Id = Guid.Parse("ceed30c6-883e-43d4-94f1-f4fdde4c2913"), Type = TextBlockType.Text, Text = "At 7th level, you can use skill increases to become a master in a skill in which you're already an expert, and at 15th level, you can use them to become legendary in a skill in which you're already a master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSkillIncrease(Guid.Parse("e056ea16-db51-412f-b4a7-bd4fb9b05dbc"), Guid.Parse("1b4c8c22-75e6-4419-9c96-5fdbad028c58"), requiredLevel: 3);
            builder.GainSkillIncrease(Guid.Parse("4de6f7e0-31b5-4d7a-a7cb-734f7baec7a4"), Guid.Parse("4eb9da42-642b-45be-bd52-691e84fca690"), requiredLevel: 5);
            builder.GainSkillIncrease(Guid.Parse("88163a7a-67ab-4462-9f24-a8c8446219bc"), Guid.Parse("5b8b687a-22b2-4abe-8def-d2c84bd97e77"), requiredLevel: 7);
            builder.GainSkillIncrease(Guid.Parse("316a438c-c7f3-4c0c-a30d-19f50df9f8da"), Guid.Parse("010e82ab-928c-4096-9553-7a82878ce137"), requiredLevel: 9);
            builder.GainSkillIncrease(Guid.Parse("4ca3ca25-87d6-4396-95a3-d035322a9d3f"), Guid.Parse("2b76cbf1-5634-4ece-bae5-0a11b2b85ddb"), requiredLevel: 11);
            builder.GainSkillIncrease(Guid.Parse("2e85f4b2-629f-4951-800e-5637342c99c7"), Guid.Parse("3697bab1-485a-45f8-a9f5-7b3cb0b73898"), requiredLevel: 13);
            builder.GainSkillIncrease(Guid.Parse("61d1ba05-e0ac-4a85-b799-c0711e5c5e25"), Guid.Parse("6f5c567e-0281-48c7-a9cc-8c9a0fc936df"), requiredLevel: 15);
            builder.GainSkillIncrease(Guid.Parse("c9b305ea-67cc-446e-be96-d87b8476d4d8"), Guid.Parse("083529d9-b2d7-4761-aab5-7bef46b4f5ef"), requiredLevel: 17);
            builder.GainSkillIncrease(Guid.Parse("b3d98076-6730-4723-aeb6-831140402bab"), Guid.Parse("04a963c5-ca5a-49ec-9ebf-ba2c4901da13"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a4d7be7a-4fa2-4b5d-98ba-fd6fef2dc42f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 40
            };
        }
    }
}
