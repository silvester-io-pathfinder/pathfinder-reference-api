using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Alchemists
{
    public class SkillIncreases : Template
    {
        public static readonly Guid ID = Guid.Parse("c87ab305-bc48-4d32-ac76-365ec59a448d");

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
            yield return new TextBlock { Id = Guid.Parse("bccca177-9984-4923-a3ef-c2154597a513"), Type = TextBlockType.Text, Text = "At 3rd level and every 2 levels thereafter, you gain a skill increase. You can use this skill increase to become trained in one skill you're untrained in, or become an expert in one skill in which you are already trained." };
            yield return new TextBlock { Id = Guid.Parse("9c942549-1275-4eee-a140-4577fb854e36"), Type = TextBlockType.Text, Text = "At 7th level, you can use skill increases to become a master in a skill in which you're already an expert, and at 15th level, you can use them to become legendary in a skill in which you're already a master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSkillIncrease(Guid.Parse("fe34a11d-da58-4111-9fc5-80660a6083d3"), Guid.Parse("d3611677-95b6-49cf-a495-28acc8e3be57"), requiredLevel: 3);
            builder.GainSkillIncrease(Guid.Parse("d07fdc97-3005-405a-83d6-d45bffcea577"), Guid.Parse("96ff5bcf-d362-46c1-9b1c-b649ca802681"), requiredLevel: 5);
            builder.GainSkillIncrease(Guid.Parse("2d42aa53-31e5-4acd-b4c9-f40867ab9c05"), Guid.Parse("c522ae29-b660-4cf3-8410-adacef7053d9"), requiredLevel: 7);
            builder.GainSkillIncrease(Guid.Parse("16be51af-a481-46f0-b8f6-d52602afe3c4"), Guid.Parse("67a3aab2-641b-4343-9f06-f0ba0d878b3e"), requiredLevel: 9);
            builder.GainSkillIncrease(Guid.Parse("9f319ac4-1901-40a7-a76b-8209d1d5ff59"), Guid.Parse("69457b2b-701b-40bf-bec8-498c30f0b6b8"), requiredLevel: 11);
            builder.GainSkillIncrease(Guid.Parse("1841b018-7e26-482a-89e5-de0a2fa43736"), Guid.Parse("25daa436-b480-47ea-9540-fa47c1305cc5"), requiredLevel: 13);
            builder.GainSkillIncrease(Guid.Parse("25114f09-32b9-4340-a77b-d2cee9d7b26d"), Guid.Parse("7501f06f-b33c-4940-9dd2-b488e09b92aa"), requiredLevel: 15);
            builder.GainSkillIncrease(Guid.Parse("4221aa03-1f84-4304-8822-a759f86e9028"), Guid.Parse("a4a54850-c049-4dad-b815-c247dfa28f31"), requiredLevel: 17);
            builder.GainSkillIncrease(Guid.Parse("551afd01-3c4d-4228-9b57-bfaa79a8571e"), Guid.Parse("e360409b-8fda-4873-bb6a-d8e26dbf2c40"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c1385aa1-6357-4ee5-bb54-d91c0262dbfe"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 74
            };
        }
    }
}
