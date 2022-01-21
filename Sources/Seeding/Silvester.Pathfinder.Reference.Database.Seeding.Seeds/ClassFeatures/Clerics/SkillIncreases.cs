using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Clerics
{
    public class SkillIncreases : Template
    {
        public static readonly Guid ID = Guid.Parse("63fbbbf3-9139-4e07-9106-6012632040d9");

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
            yield return new TextBlock { Id = Guid.Parse("af078060-f601-4c0f-8ec4-6d2cf8a9dcb5"), Type = TextBlockType.Text, Text = "At 3rd level and every 2 levels thereafter, you gain a skill increase. You can use this skill increase to become trained in one skill you're untrained in, or become an expert in one skill in which you are already trained." };
            yield return new TextBlock { Id = Guid.Parse("986ad54f-e70f-45f2-8fcb-413b5806706e"), Type = TextBlockType.Text, Text = "At 7th level, you can use skill increases to become a master in a skill in which you're already an expert, and at 15th level, you can use them to become legendary in a skill in which you're already a master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSkillIncrease(Guid.Parse("bade0cb2-aa07-4dff-a1ee-d03c4cc6aaab"), Guid.Parse("85e04c83-159f-4a49-884e-afefbc3d570e"), requiredLevel: 3);
            builder.GainSkillIncrease(Guid.Parse("73984dee-4ca7-4c0a-be61-d615f7ad6163"), Guid.Parse("e53fc831-d792-4378-b029-68fc5b30ed87"), requiredLevel: 5);
            builder.GainSkillIncrease(Guid.Parse("45deb2d0-4bda-433d-83f7-a3044d00b10b"), Guid.Parse("80344ce4-8e4b-4a53-9caf-c583efa273c1"), requiredLevel: 7);
            builder.GainSkillIncrease(Guid.Parse("e02ea05c-5ec0-4386-8cea-771439bf0f69"), Guid.Parse("30ea8cb8-3037-4471-871d-c976599cfb24"), requiredLevel: 9);
            builder.GainSkillIncrease(Guid.Parse("4679cf72-5ea8-4e15-8b41-77dcba7b0449"), Guid.Parse("85eddebe-57bb-4bad-9ce5-92f58fcec192"), requiredLevel: 11);
            builder.GainSkillIncrease(Guid.Parse("0bc673e3-9d69-4043-b8df-99f4fd1e5154"), Guid.Parse("692203fc-a9c9-419d-a6f2-98f33ff7b651"), requiredLevel: 13);
            builder.GainSkillIncrease(Guid.Parse("8fe7453d-e6cc-43b5-b9e8-f6f9d411b159"), Guid.Parse("4c6e876d-1dc4-44fa-a86b-aa1d83ca0b14"), requiredLevel: 15);
            builder.GainSkillIncrease(Guid.Parse("d301eb55-5c2d-4845-95f2-492ccb18e449"), Guid.Parse("8ee9a1d4-50eb-423a-831e-9db672431741"), requiredLevel: 17);
            builder.GainSkillIncrease(Guid.Parse("520db9c1-cea8-4577-8c58-3f0df4b3523f"), Guid.Parse("7a3fa925-2586-4f0d-95ed-f4b6aca29f94"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("774b2808-3439-4143-81a2-7fb3279f1bcb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 120
            };
        }
    }
}
