using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Bards
{
    public class SkillIncreases : Template
    {
        public static readonly Guid ID = Guid.Parse("d3d294c8-5d3e-4710-9946-dd8f64337605");

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
            yield return new TextBlock { Id = Guid.Parse("13553190-e839-454c-b656-5416f68c6641"), Type = TextBlockType.Text, Text = "At 3rd level and every 2 levels thereafter, you gain a skill increase. You can use this skill increase to become trained in one skill you're untrained in, or become an expert in one skill in which you are already trained." };
            yield return new TextBlock { Id = Guid.Parse("1976b193-fc70-4330-8191-ad591d8394bb"), Type = TextBlockType.Text, Text = "At 7th level, you can use skill increases to become a master in a skill in which you're already an expert, and at 15th level, you can use them to become legendary in a skill in which you're already a master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSkillIncrease(Guid.Parse("7a8d2261-3e9b-41ca-b1f4-37793929a064"), Guid.Parse("fd1cc145-64f9-4cf2-943c-99bffc12413b"), requiredLevel: 3);
            builder.GainSkillIncrease(Guid.Parse("7bcadba7-4646-4895-8eb7-49762f43f3c6"), Guid.Parse("5436b2a7-b265-45a9-8f73-73328d34e2a9"), requiredLevel: 5);
            builder.GainSkillIncrease(Guid.Parse("3bdbfdd3-e40f-4ca8-81f7-e13bb0a66343"), Guid.Parse("4ef5826c-dcb3-41d1-b937-5a616c40d55b"), requiredLevel: 7);
            builder.GainSkillIncrease(Guid.Parse("b3b1ca5d-e07f-4242-b72e-bb15db1ceb4f"), Guid.Parse("d6b68713-555e-44c9-96ca-ea28e3418e8e"), requiredLevel: 9);
            builder.GainSkillIncrease(Guid.Parse("ae02c229-4d2b-4e0e-b402-82bb66853e33"), Guid.Parse("4b894bd8-f535-454d-9137-db5701b95fa1"), requiredLevel: 11);
            builder.GainSkillIncrease(Guid.Parse("5e178570-bfb0-43a2-9a65-0fa14d49566d"), Guid.Parse("645f8cf3-c988-4368-9749-23df299881c4"), requiredLevel: 13);
            builder.GainSkillIncrease(Guid.Parse("ee368caa-a95d-4f72-afd4-2d11ebec520e"), Guid.Parse("57006d7f-094d-4499-85b5-9894b1624fb0"), requiredLevel: 15);
            builder.GainSkillIncrease(Guid.Parse("b1c34dcc-fb8f-4609-b458-ebf844fd9fe2"), Guid.Parse("573e6d95-db1c-4a2e-9fbf-83bcdc3e58bc"), requiredLevel: 17);
            builder.GainSkillIncrease(Guid.Parse("705d2e48-093b-49a8-9d59-aaa723dda3f0"), Guid.Parse("b34a77c2-133e-4595-9534-9192754c0502"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("45f2389f-ceea-4665-b18b-3b6a405c35df"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 98
            };
        }
    }
}
