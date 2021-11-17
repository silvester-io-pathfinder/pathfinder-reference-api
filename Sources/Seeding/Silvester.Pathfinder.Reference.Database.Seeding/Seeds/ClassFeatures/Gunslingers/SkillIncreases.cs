using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Gunslingers
{
    public class SkillIncreases : Template
    {
        public static readonly Guid ID = Guid.Parse("d641e3bc-c2cb-4fc5-b471-b21d5bde307a");

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
            yield return new TextBlock { Id = Guid.Parse("43f678ee-5721-4880-b096-eeaad2bc31c2"), Type = TextBlockType.Text, Text = "At 3rd level and every 2 levels thereafter, you gain a skill increase. You can use this skill increase to become trained in one skill you're untrained in, or become an expert in one skill in which you are already trained." };
            yield return new TextBlock { Id = Guid.Parse("db53edd3-2805-4828-91f4-ef5cedc00251"), Type = TextBlockType.Text, Text = "At 7th level, you can use skill increases to become a master in a skill in which you're already an expert, and at 15th level, you can use them to become legendary in a skill in which you're already a master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSkillIncrease(Guid.Parse("73033388-cbcb-45dd-b2a0-505c896ced17"), Guid.Parse("ded9a5c4-6c8c-474b-b47d-a6012fe768b3"), requiredLevel: 3);
            builder.GainSkillIncrease(Guid.Parse("500b95c6-c080-4c97-9bbd-2a1032d6e550"), Guid.Parse("21934bbc-5282-4660-a29c-e4460033b9d9"), requiredLevel: 5);
            builder.GainSkillIncrease(Guid.Parse("0eca888d-810a-4319-ad86-4b1bfc0008a4"), Guid.Parse("c84495df-b8ec-4c7a-ba27-c547847e04c5"), requiredLevel: 7);
            builder.GainSkillIncrease(Guid.Parse("b5afe329-d959-44b6-828d-0744450d1aa3"), Guid.Parse("1d207537-2992-4182-b200-c44576a24c32"), requiredLevel: 9);
            builder.GainSkillIncrease(Guid.Parse("efa1c716-a9d3-4c34-9f48-5fd5f928a87f"), Guid.Parse("9d5a3b86-6e5e-4e78-b647-c41435e5713d"), requiredLevel: 11);
            builder.GainSkillIncrease(Guid.Parse("fee4466b-47b8-49d0-8702-95f823de3baf"), Guid.Parse("0394268b-af71-4f2f-b43f-a66c5c74797b"), requiredLevel: 13);
            builder.GainSkillIncrease(Guid.Parse("1b16a140-cd62-42a7-b920-6a4094373352"), Guid.Parse("b7d7285d-a29f-43ec-8a81-cee93ae354e7"), requiredLevel: 15);
            builder.GainSkillIncrease(Guid.Parse("b88be5bc-ec25-4c02-86cb-9696001c8802"), Guid.Parse("83c936ec-f0bc-4f4a-942f-c50046e4c7f8"), requiredLevel: 17);
            builder.GainSkillIncrease(Guid.Parse("2d75df46-162a-4e7d-a8df-2a80a4f2f59c"), Guid.Parse("3dfe6db0-6630-4b4e-bf42-312caaa9d398"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1321db53-53f8-4fab-b897-24a772c9a046"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 106
            };
        }
    }
}
