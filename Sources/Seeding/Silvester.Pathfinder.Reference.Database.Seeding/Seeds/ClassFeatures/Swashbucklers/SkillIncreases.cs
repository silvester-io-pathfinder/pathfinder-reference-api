using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Swashbucklers
{
    public class SkillIncreases : Template
    {
        public static readonly Guid ID = Guid.Parse("a96150cb-f069-4818-9f4c-fa3d4bc28e47");

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
            yield return new TextBlock { Id = Guid.Parse("845c8ff4-6cad-45b9-8644-09834b9b918a"), Type = TextBlockType.Text, Text = "At 3rd level and every 2 levels thereafter, you gain a skill increase. You can use this skill increase to become trained in one skill you're untrained in, or become an expert in one skill in which you are already trained." };
            yield return new TextBlock { Id = Guid.Parse("2e9ab880-c2ac-4e30-b806-d1939ec987ab"), Type = TextBlockType.Text, Text = "At 7th level, you can use skill increases to become a master in a skill in which you're already an expert, and at 15th level, you can use them to become legendary in a skill in which you're already a master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSkillIncrease(Guid.Parse("aeda4345-0929-4186-81b8-07cb8012f9fa"), Guid.Parse("d36df77d-ead0-4406-b554-2977b6231ed7"), requiredLevel: 3);
            builder.GainSkillIncrease(Guid.Parse("d251f0a0-1aa5-4f4a-980f-bc5b9bbb7169"), Guid.Parse("309d244c-8968-472c-a884-b8d36d20c1fd"), requiredLevel: 5);
            builder.GainSkillIncrease(Guid.Parse("5a69ee2c-89b6-4a86-8e8d-429eb8367902"), Guid.Parse("1593636b-3fc2-4ba5-86b9-051516965af9"), requiredLevel: 7);
            builder.GainSkillIncrease(Guid.Parse("c6f4b5fb-2807-463e-a512-334cc35f3acd"), Guid.Parse("9b6e5f1e-bf5c-4d29-a931-570e1d8f4968"), requiredLevel: 9);
            builder.GainSkillIncrease(Guid.Parse("5bc3802b-9d18-4416-8746-13b96df14737"), Guid.Parse("d5a823dd-2055-4f71-9a6a-3442a86cfdcb"), requiredLevel: 11);
            builder.GainSkillIncrease(Guid.Parse("c0122c71-9b96-4025-a555-bbf1d0243b58"), Guid.Parse("3b677fa8-9e28-443f-9aec-847a04481044"), requiredLevel: 13);
            builder.GainSkillIncrease(Guid.Parse("62b6269d-0868-4a85-9f57-81bdf38220e9"), Guid.Parse("e91bc80f-6fb8-41e6-95dd-a898a27ca4e9"), requiredLevel: 15);
            builder.GainSkillIncrease(Guid.Parse("d6b3494d-daf2-462b-af37-1a27704cead1"), Guid.Parse("5adf34a3-cb8a-4de0-a7e8-684d60806a8a"), requiredLevel: 17);
            builder.GainSkillIncrease(Guid.Parse("5d891a1c-c86a-448a-b3b4-5348f81056b4"), Guid.Parse("40cb9736-ef59-4603-bb86-bcfaea45e71b"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("76b6a6de-f12d-44c8-b75c-350e9a61991a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 85
            };
        }
    }
}
