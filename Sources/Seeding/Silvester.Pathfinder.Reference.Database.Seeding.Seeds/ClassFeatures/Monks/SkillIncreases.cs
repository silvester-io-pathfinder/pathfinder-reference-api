using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Monks
{
    public class SkillIncreases : Template
    {
        public static readonly Guid ID = Guid.Parse("f9bd2318-4c51-4e5f-97ad-17c19f2c1ea6");

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
            yield return new TextBlock { Id = Guid.Parse("76aa940f-583a-46a4-9bac-4a051ad1f27e"), Type = TextBlockType.Text, Text = "At 3rd level and every 2 levels thereafter, you gain a skill increase. You can use this skill increase to become trained in one skill you're untrained in, or become an expert in one skill in which you are already trained." };
            yield return new TextBlock { Id = Guid.Parse("a6aa3bc3-54f7-414c-be08-9cbfba29fdf6"), Type = TextBlockType.Text, Text = "At 7th level, you can use skill increases to become a master in a skill in which you're already an expert, and at 15th level, you can use them to become legendary in a skill in which you're already a master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSkillIncrease(Guid.Parse("12d29fd6-a973-44cf-a54e-c882831a1c64"), Guid.Parse("5cc01028-3216-4524-bdcc-25575ea4f853"), requiredLevel: 3);
            builder.GainSkillIncrease(Guid.Parse("56ca58ee-8801-477c-85d4-734bae7a1cb2"), Guid.Parse("ccb2c719-52f6-464f-b1bf-09ad6394e797"), requiredLevel: 5);
            builder.GainSkillIncrease(Guid.Parse("773f973e-4617-418a-9016-540b69496abf"), Guid.Parse("086d5afc-e0eb-4c15-aeae-816c20a6713b"), requiredLevel: 7);
            builder.GainSkillIncrease(Guid.Parse("b66ebca0-2845-4765-81e2-95568ae2f94c"), Guid.Parse("19e71986-eb77-4f8d-865e-0ba5c50569b5"), requiredLevel: 9);
            builder.GainSkillIncrease(Guid.Parse("bd75e35b-95cf-4351-8a34-320fa4e864e8"), Guid.Parse("5aa0f434-045d-45b8-b3a9-55c6fc64186f"), requiredLevel: 11);
            builder.GainSkillIncrease(Guid.Parse("fed21620-dd21-4595-8db4-92e71ebb61db"), Guid.Parse("ed2c2e05-d784-4e69-82cc-df40c0855ada"), requiredLevel: 13);
            builder.GainSkillIncrease(Guid.Parse("9f1e8ea0-9bfe-4313-8e40-68cd70f7e1e0"), Guid.Parse("188de9e3-a147-4265-8bd7-f7016954a1bd"), requiredLevel: 15);
            builder.GainSkillIncrease(Guid.Parse("89e50b0a-d555-47b9-87e6-a6da8d3a47c5"), Guid.Parse("b478eac8-6c81-4cf8-a310-6da0e2acbb5c"), requiredLevel: 17);
            builder.GainSkillIncrease(Guid.Parse("a960d4c2-6ab2-4f3a-8d1b-78c4797327dd"), Guid.Parse("a23c7568-b727-49c7-97ef-03f952a2f0a1"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("645ea0a2-128d-4a4b-ae0a-d557a9ee02c7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 156
            };
        }
    }
}
