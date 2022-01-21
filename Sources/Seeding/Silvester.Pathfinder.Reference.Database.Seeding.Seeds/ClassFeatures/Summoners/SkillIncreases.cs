using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Summoners
{
    public class SkillIncreases : Template
    {
        public static readonly Guid ID = Guid.Parse("7a8a6486-9063-4cac-b499-982aa5c7d4aa");

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
            yield return new TextBlock { Id = Guid.Parse("6a02d653-e40d-46c5-8505-62276951b2dc"), Type = TextBlockType.Text, Text = "At 3rd level and every 2 levels thereafter, you gain a skill increase. You can use this skill increase to become trained in one skill you're untrained in, or become an expert in one skill in which you are already trained." };
            yield return new TextBlock { Id = Guid.Parse("05a8e2dd-8b9d-412c-8d85-c425eb50f019"), Type = TextBlockType.Text, Text = "At 7th level, you can use skill increases to become a master in a skill in which you're already an expert, and at 15th level, you can use them to become legendary in a skill in which you're already a master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSkillIncrease(Guid.Parse("abcfb643-5def-4f47-9083-6f71446fee6d"), Guid.Parse("7e4a2f8f-3214-4f13-ada1-2be9ed4ab381"), requiredLevel: 3);
            builder.GainSkillIncrease(Guid.Parse("9d06640a-60cf-4e30-a579-3085e609b0e0"), Guid.Parse("05c52856-4063-4b3d-85ef-71e272c5997b"), requiredLevel: 5);
            builder.GainSkillIncrease(Guid.Parse("eedb0e54-faa4-4a88-904b-eae73d7453ca"), Guid.Parse("d7e53b9e-ad3b-4794-a6af-8b38fc27db51"), requiredLevel: 7);
            builder.GainSkillIncrease(Guid.Parse("5be9f46a-b8b3-44e7-a024-bae0c4f4e513"), Guid.Parse("65e8efb1-c648-4244-9124-84b9ba2c72d4"), requiredLevel: 9);
            builder.GainSkillIncrease(Guid.Parse("445cea3a-67d5-4c9b-b984-79d16be582c9"), Guid.Parse("95df048c-db3f-4cbc-aa0b-9c999a904911"), requiredLevel: 11);
            builder.GainSkillIncrease(Guid.Parse("3c1637de-cdbf-4f96-a21e-ddde6a0ab805"), Guid.Parse("3b59b7c7-9501-43ed-b579-b2039bf323df"), requiredLevel: 13);
            builder.GainSkillIncrease(Guid.Parse("c4fe8be0-45a9-4d21-be7d-3177fcd559ee"), Guid.Parse("30ff393f-08ce-4fac-a76e-b5de929418f5"), requiredLevel: 15);
            builder.GainSkillIncrease(Guid.Parse("ecb50bf9-3d73-4521-9526-4986e4d06951"), Guid.Parse("6b5c1cc2-9062-4cd8-813b-5ff4cb8ff420"), requiredLevel: 17);
            builder.GainSkillIncrease(Guid.Parse("c7ef862a-a12f-41e3-9407-8b29c27db0de"), Guid.Parse("a64757a2-4267-42e4-8c85-544bf803fc56"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dbeb5153-f194-49f8-8ad3-348ff682ad08"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 56
            };
        }
    }
}
