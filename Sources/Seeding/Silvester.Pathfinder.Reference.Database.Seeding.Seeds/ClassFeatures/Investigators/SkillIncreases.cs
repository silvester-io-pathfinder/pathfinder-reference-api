using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Investigators
{
    public class SkillIncreases : Template
    {
        public static readonly Guid ID = Guid.Parse("3e0c8f9a-f4f9-4b8d-b1e3-1753be73ff0f");

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
            yield return new TextBlock { Id = Guid.Parse("8012ad0a-40f0-4670-9469-7b3f7b446e89"), Type = TextBlockType.Text, Text = "At 3rd level and every 2 levels thereafter, you gain a skill increase. You can use this skill increase to become trained in one skill you're untrained in, or become an expert in one skill in which you are already trained." };
            yield return new TextBlock { Id = Guid.Parse("8818b4d6-ba91-4c0e-b4ef-638de5f6f3e7"), Type = TextBlockType.Text, Text = "At 7th level, you can use skill increases to become a master in a skill in which you're already an expert, and at 15th level, you can use them to become legendary in a skill in which you're already a master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSkillIncrease(Guid.Parse("75df0438-a7b8-47d0-9cfa-043669772d6a"), Guid.Parse("5942093e-46b5-464a-8209-ef6ea40e25ef"), requiredLevel: 3);
            builder.GainSkillIncrease(Guid.Parse("8da75dba-6449-4424-9db2-f31e70193a1c"), Guid.Parse("c6ec79e1-878d-4654-a566-24e38f57a97e"), requiredLevel: 5);
            builder.GainSkillIncrease(Guid.Parse("cf48c43f-d695-4e9d-b42d-0eeff00c4404"), Guid.Parse("e9141817-0574-476f-9cdb-11aec43eef66"), requiredLevel: 7);
            builder.GainSkillIncrease(Guid.Parse("856ace11-a125-4fa8-9e44-d9873d960f8e"), Guid.Parse("ebd015ee-36d2-4bca-a235-85557eb0f59d"), requiredLevel: 9);
            builder.GainSkillIncrease(Guid.Parse("984d4a21-0015-45a9-b5fa-9786e69904a3"), Guid.Parse("50a8c42b-34d3-4939-8edd-eb31b0679dc1"), requiredLevel: 11);
            builder.GainSkillIncrease(Guid.Parse("956b4128-b918-41aa-b70c-8ec1db5e85db"), Guid.Parse("16f8c6b1-6c81-4934-b528-acddf7e83671"), requiredLevel: 13);
            builder.GainSkillIncrease(Guid.Parse("a4cbb774-5b16-42f8-9ed0-952c0465a413"), Guid.Parse("6219ceaf-122f-464f-bdb4-7b19eaf1f34a"), requiredLevel: 15);
            builder.GainSkillIncrease(Guid.Parse("f1c5545d-cc59-4b7e-93b8-29c9613c723e"), Guid.Parse("69c6c3f1-1ea1-46fd-bf03-0230e7655dcf"), requiredLevel: 17);
            builder.GainSkillIncrease(Guid.Parse("211ff709-013d-419f-a7ca-599989aaa997"), Guid.Parse("abfe8f6c-101c-4f84-bfc2-d0121f03cf06"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2c619764-4de7-4f1d-8b98-bef765013677"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 59
            };
        }
    }
}
