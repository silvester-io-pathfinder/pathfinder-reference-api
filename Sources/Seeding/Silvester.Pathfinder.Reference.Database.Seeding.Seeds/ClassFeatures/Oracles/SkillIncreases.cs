using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Oracles
{
    public class SkillIncreases : Template
    {
        public static readonly Guid ID = Guid.Parse("98a11a7c-2446-46db-956c-ea5b1aff5890");

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
            yield return new TextBlock { Id = Guid.Parse("aa27aaa1-0c8c-40d4-8a3a-88831962fc78"), Type = TextBlockType.Text, Text = "At 3rd level and every 2 levels thereafter, you gain a skill increase. You can use this skill increase to become trained in one skill you're untrained in, or become an expert in one skill in which you are already trained." };
            yield return new TextBlock { Id = Guid.Parse("e06b9bb2-6982-417f-aa20-11c661ed7a9e"), Type = TextBlockType.Text, Text = "At 7th level, you can use skill increases to become a master in a skill in which you're already an expert, and at 15th level, you can use them to become legendary in a skill in which you're already a master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSkillIncrease(Guid.Parse("79c454f2-0b65-4d29-8055-9d3245b6c208"), Guid.Parse("f53d5671-4b98-4a5d-a6c6-5832eff08c10"), requiredLevel: 3);
            builder.GainSkillIncrease(Guid.Parse("7754cc47-9a53-40b9-b5ba-4526e92e5ca5"), Guid.Parse("19690c93-cfe9-448c-88b1-fb4613f83a73"), requiredLevel: 5);
            builder.GainSkillIncrease(Guid.Parse("d566b108-c730-4e25-909d-66086139c802"), Guid.Parse("515cc0ff-f2bf-4509-9232-3da25b50b64e"), requiredLevel: 7);
            builder.GainSkillIncrease(Guid.Parse("2fe9fe5f-6ee9-47a7-9659-62a5e053a2b3"), Guid.Parse("7616ac1e-31c1-4159-9323-9c1d762800bf"), requiredLevel: 9);
            builder.GainSkillIncrease(Guid.Parse("f2a5da48-feb5-4d75-8f08-022b2fdd4354"), Guid.Parse("0c6df343-fe0f-446c-aa28-c4471718062d"), requiredLevel: 11);
            builder.GainSkillIncrease(Guid.Parse("855bbe32-a793-47fe-a5ee-cb43318c50dd"), Guid.Parse("cca2c226-ff65-4b90-95f6-97027f04dbbc"), requiredLevel: 13);
            builder.GainSkillIncrease(Guid.Parse("6c390198-84ed-46e3-8d50-c37b4dd1505f"), Guid.Parse("1998945e-1306-419c-aff1-9c87848e2572"), requiredLevel: 15);
            builder.GainSkillIncrease(Guid.Parse("775e1394-4608-4d26-945f-19c8516e993d"), Guid.Parse("339f16e6-ec20-45cd-985c-8eddf54cec1e"), requiredLevel: 17);
            builder.GainSkillIncrease(Guid.Parse("d717e413-6aca-4328-ba64-f81877d239ad"), Guid.Parse("cdd9dc53-60af-4149-9bbc-29db92d5ede9"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c04eecbf-4803-41c9-a664-9236b837cd6c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 71
            };
        }
    }
}
