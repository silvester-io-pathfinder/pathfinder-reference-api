using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Sorcerers
{
    public class SkillIncreases : Template
    {
        public static readonly Guid ID = Guid.Parse("a1f9a66e-cbd4-44a0-9cd7-2a24ad9335bf");

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
            yield return new TextBlock { Id = Guid.Parse("c53b246a-d316-49b0-b3e3-43631334d67b"), Type = TextBlockType.Text, Text = "At 3rd level and every 2 levels thereafter, you gain a skill increase. You can use this skill increase to become trained in one skill you're untrained in, or become an expert in one skill in which you are already trained." };
            yield return new TextBlock { Id = Guid.Parse("d2992114-550b-4406-90f1-2b34761ee4fd"), Type = TextBlockType.Text, Text = "At 7th level, you can use skill increases to become a master in a skill in which you're already an expert, and at 15th level, you can use them to become legendary in a skill in which you're already a master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSkillIncrease(Guid.Parse("24c4c7a6-231c-4196-a0d0-4ca386991881"), Guid.Parse("94fedc1d-8a66-4d86-af41-2e6506e79591"), requiredLevel: 3);
            builder.GainSkillIncrease(Guid.Parse("f05d223f-d120-4c4f-b47b-2c653a8b61d8"), Guid.Parse("ee56367a-c7aa-4f52-b006-e5cae3780d47"), requiredLevel: 5);
            builder.GainSkillIncrease(Guid.Parse("4880411b-1e68-4edc-81fd-0a3982d5a309"), Guid.Parse("f3134778-8c87-4471-8af8-2eddd57dfdce"), requiredLevel: 7);
            builder.GainSkillIncrease(Guid.Parse("0d81681f-5884-4ba6-a2dc-7490fc6bf4e6"), Guid.Parse("1c66c020-5963-4eae-82f3-187c98e79b30"), requiredLevel: 9);
            builder.GainSkillIncrease(Guid.Parse("8d839c3e-0269-4991-8f36-68643c1bb401"), Guid.Parse("3adbac15-9dd7-4356-82ae-e8c79fd083d5"), requiredLevel: 11);
            builder.GainSkillIncrease(Guid.Parse("e68bfe66-1452-47cb-b29e-31301e8766d0"), Guid.Parse("32bffe09-6c9d-486b-ba62-4558de552fee"), requiredLevel: 13);
            builder.GainSkillIncrease(Guid.Parse("905bd995-6fcd-41e8-b6c2-34e4e58da55d"), Guid.Parse("bef9b6ed-63d9-4396-aa06-25c224384854"), requiredLevel: 15);
            builder.GainSkillIncrease(Guid.Parse("5ff2b5ad-f9a7-4fae-b0c2-0bc00216ff69"), Guid.Parse("474952c2-ebc1-461e-a918-0b9f97f73d24"), requiredLevel: 17);
            builder.GainSkillIncrease(Guid.Parse("f04cf4e9-b81c-4fc7-8207-bfe0299917d3"), Guid.Parse("8408a1d6-65ae-4069-9165-04462123b4b2"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4dac716c-bb99-42fc-a0d0-7097aa2f40c8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 194
            };
        }
    }
}
