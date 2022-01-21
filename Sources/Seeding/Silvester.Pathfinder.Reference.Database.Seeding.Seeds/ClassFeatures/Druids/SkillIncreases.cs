using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Druids
{
    public class SkillIncreases : Template
    {
        public static readonly Guid ID = Guid.Parse("2f9f522b-5329-44e2-a33b-d39f48692954");

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
            yield return new TextBlock { Id = Guid.Parse("78899d54-e4c5-4ac9-805a-3064757d73af"), Type = TextBlockType.Text, Text = "At 3rd level and every 2 levels thereafter, you gain a skill increase. You can use this skill increase to become trained in one skill you're untrained in, or become an expert in one skill in which you are already trained." };
            yield return new TextBlock { Id = Guid.Parse("2e5bc5aa-b92a-442d-b3f0-1f923ae7ae58"), Type = TextBlockType.Text, Text = "At 7th level, you can use skill increases to become a master in a skill in which you're already an expert, and at 15th level, you can use them to become legendary in a skill in which you're already a master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSkillIncrease(Guid.Parse("10dd461a-4e75-40bf-ac34-f129646e7886"), Guid.Parse("98c88058-55b1-4826-b4df-c291dfbe22f3"), requiredLevel: 3);
            builder.GainSkillIncrease(Guid.Parse("1fd25264-bb0f-4084-8224-0115759b2955"), Guid.Parse("1b903de6-a7c3-43c7-be53-d3cca21f2d85"), requiredLevel: 5);
            builder.GainSkillIncrease(Guid.Parse("6fa3b4c8-ee0d-4de8-b3c6-354539d2f894"), Guid.Parse("13fa6488-98a1-4629-bf7d-fb2abfec8674"), requiredLevel: 7);
            builder.GainSkillIncrease(Guid.Parse("664a58c9-5711-4155-b0c3-b36ba4260273"), Guid.Parse("c7c75c1f-711e-4f86-92f7-32e4498646f7"), requiredLevel: 9);
            builder.GainSkillIncrease(Guid.Parse("de38da6e-1f0e-45e9-93be-c7d68ae1c387"), Guid.Parse("639e0d09-dfee-4cd2-ad0f-80e8ed64c60b"), requiredLevel: 11);
            builder.GainSkillIncrease(Guid.Parse("6990294c-aa4f-4d0d-aeed-72d08b3e67d8"), Guid.Parse("2581018d-fbd0-4983-ac98-34b92c0e958c"), requiredLevel: 13);
            builder.GainSkillIncrease(Guid.Parse("97863c7e-c106-436f-8d20-118e3f7b7829"), Guid.Parse("8e9fb34e-2eda-4df4-a716-807b676f2197"), requiredLevel: 15);
            builder.GainSkillIncrease(Guid.Parse("40b6620d-bc0c-4eab-bcde-49c0cb3d07c3"), Guid.Parse("0cee82f9-7134-4e14-aaac-559f99273991"), requiredLevel: 17);
            builder.GainSkillIncrease(Guid.Parse("720d955c-fb1f-478e-a790-1157207cfe78"), Guid.Parse("43396273-edb9-4320-af4d-9fba6b427a49"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d73468a8-0fa1-4a5d-b532-4ec6167e3202"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 133
            };
        }
    }
}
