using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Champions
{
    public class SkillIncreases : Template
    {
        public static readonly Guid ID = Guid.Parse("43b662a7-06f3-4145-975f-a47c3e5d008a");

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
            yield return new TextBlock { Id = Guid.Parse("c417be89-fe87-4a01-85a3-7e3274689385"), Type = TextBlockType.Text, Text = "At 3rd level and every 2 levels thereafter, you gain a skill increase. You can use this skill increase to become trained in one skill you're untrained in, or become an expert in one skill in which you are already trained." };
            yield return new TextBlock { Id = Guid.Parse("bce81d0e-c14c-4e21-8408-61b6a48c0b8c"), Type = TextBlockType.Text, Text = "At 7th level, you can use skill increases to become a master in a skill in which you're already an expert, and at 15th level, you can use them to become legendary in a skill in which you're already a master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSkillIncrease(Guid.Parse("7b970cde-11b8-487a-a238-7a0373741642"), Guid.Parse("7b7ad5f4-1e7c-42f5-9c6b-dc7b4e8f8ff6"), requiredLevel: 3);
            builder.GainSkillIncrease(Guid.Parse("23afb3f2-7c98-48a3-96ba-8bcfa4eecbf7"), Guid.Parse("8019d9af-c269-464c-a3e0-8e265ca3a991"), requiredLevel: 5);
            builder.GainSkillIncrease(Guid.Parse("90c29c07-9194-4a2e-9427-b210cce9aca8"), Guid.Parse("bb8f1938-ab80-4083-beec-6dd0d1bbf65e"), requiredLevel: 7);
            builder.GainSkillIncrease(Guid.Parse("449101aa-bc31-4e75-bb7c-a4544bb25891"), Guid.Parse("5ff8709f-750e-4a9e-81df-44c4d6b9572e"), requiredLevel: 9);
            builder.GainSkillIncrease(Guid.Parse("1376edef-76fc-4787-be37-e2f348ef2e30"), Guid.Parse("6ae7a087-01af-4b55-8aba-38efa4f3ddf8"), requiredLevel: 11);
            builder.GainSkillIncrease(Guid.Parse("ba5e2923-9bec-4e70-a519-684952b7e26a"), Guid.Parse("41c057ff-810c-4caa-adf8-cc7d22dfc955"), requiredLevel: 13);
            builder.GainSkillIncrease(Guid.Parse("6b55f47f-32e5-45e4-8c47-94af8ae0eb66"), Guid.Parse("3c925f29-0d81-4ea6-ba2a-6cf712329a88"), requiredLevel: 15);
            builder.GainSkillIncrease(Guid.Parse("b5a52ad9-c3bb-472f-85a8-fda4839b3f1a"), Guid.Parse("fb174f84-f60b-495f-b93e-9192366f3ffb"), requiredLevel: 17);
            builder.GainSkillIncrease(Guid.Parse("3479d780-18e7-4c61-8752-08720af99e99"), Guid.Parse("791244a7-3c78-4c6d-9f13-c4985620177d"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e9bae598-f186-42a3-9d07-67c540039a21"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 108
            };
        }
    }
}
