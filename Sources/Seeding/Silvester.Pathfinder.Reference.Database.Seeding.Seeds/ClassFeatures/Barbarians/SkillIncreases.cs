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
    public class SkillIncreases : Template
    {
        public static readonly Guid ID = Guid.Parse("aac74d9c-9e9a-4e6c-978d-d322d40c3667");

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
            yield return new TextBlock { Id = Guid.Parse("8f2c2d29-3385-4a4d-b690-daeea36058cd"), Type = TextBlockType.Text, Text = "At 3rd level and every 2 levels thereafter, you gain a skill increase. You can use this skill increase to become trained in one skill you're untrained in, or become an expert in one skill in which you are already trained." };
            yield return new TextBlock { Id = Guid.Parse("6deb2475-9d31-41c6-a1af-205a12af43f3"), Type = TextBlockType.Text, Text = "At 7th level, you can use skill increases to become a master in a skill in which you're already an expert, and at 15th level, you can use them to become legendary in a skill in which you're already a master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSkillIncrease(Guid.Parse("203241d0-e9b3-48c2-8890-ff1003f993a2"), Guid.Parse("9168a14e-abb1-45ab-a11a-0c9d8be973fc"), requiredLevel: 3);
            builder.GainSkillIncrease(Guid.Parse("64e2acab-5b4a-415f-8fc3-721b3a026ffe"), Guid.Parse("ce3e3fa5-ddd3-4da7-a56f-36edfe049326"), requiredLevel: 5);
            builder.GainSkillIncrease(Guid.Parse("23d7b8ad-b72d-44b9-8531-38255ce91f72"), Guid.Parse("c33f048f-4060-4fb6-a509-bb4544fc847c"), requiredLevel: 7);
            builder.GainSkillIncrease(Guid.Parse("99592061-45b0-43cb-9ee4-26fd73954ca4"), Guid.Parse("434daf69-a256-43f7-a115-ea8c4cc61207"), requiredLevel: 9);
            builder.GainSkillIncrease(Guid.Parse("e8cbc8ed-b376-4222-9d79-629409ee193a"), Guid.Parse("b7f9eba1-6c4e-4d92-96c1-d91ee8cbf34f"), requiredLevel: 11);
            builder.GainSkillIncrease(Guid.Parse("78d684dd-b904-49a1-bdb8-2d7be38b48dd"), Guid.Parse("1553bfbe-6a62-4ed3-9589-3993489ecf62"), requiredLevel: 13);
            builder.GainSkillIncrease(Guid.Parse("298c43d2-1c5a-4f0e-9dd2-eefbad110e95"), Guid.Parse("cc82ade8-dbd4-4fc7-bd29-ee7152fb615d"), requiredLevel: 15);
            builder.GainSkillIncrease(Guid.Parse("b44b249c-a241-445b-b650-00e6c826155f"), Guid.Parse("0de4aeb5-b7f0-4763-9dab-77f3d5a5f932"), requiredLevel: 17);
            builder.GainSkillIncrease(Guid.Parse("11b19266-9991-421d-908a-7b85de94c50d"), Guid.Parse("61d1b0b3-351f-4294-9c5d-f1748e4bd63c"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f95e791-8603-4a65-bd34-0c2c85bd8632"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 84
            };
        }
    }
}
