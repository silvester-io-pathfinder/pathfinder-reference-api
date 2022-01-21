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
    public class SkillFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("0e7a288b-6c48-4594-9459-cc7a0b95ec0e");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 2, 
                Name = "Skill Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("66a88a44-a370-41a4-b3de-d32d3152ef0b"), Type = TextBlockType.Text, Text = "At 2nd level and every 2 levels thereafter, you gain a skill feat. Skill feats can be found in Chapter 5 of the Core Rulebook and have the skill trait. You must be trained or better in the corresponding skill to select a skill feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnySkillFeat(Guid.Parse("36eaa310-7f92-4b8f-bfd5-379eb2d021b8"), Guid.Parse("8c122bf9-61c9-468d-915a-80007259b038"), requiredLevel: 2);
            builder.GainAnySkillFeat(Guid.Parse("0c24d0b5-7415-43ba-8973-ed232e7344df"), Guid.Parse("f153518f-302f-4e51-8c07-7081663a964d"), requiredLevel: 4);
            builder.GainAnySkillFeat(Guid.Parse("bd818f64-04c7-4a51-83b6-5f311df5e9df"), Guid.Parse("e8c9cee8-34f2-4f22-a3d1-8d645f865b33"), requiredLevel: 6);
            builder.GainAnySkillFeat(Guid.Parse("6ce22cc4-6809-4bca-8fde-b06b411a5b79"), Guid.Parse("2c967854-cd47-4b60-817a-701e682846bd"), requiredLevel: 8);
            builder.GainAnySkillFeat(Guid.Parse("8134921b-8270-4b6a-9a52-f21a0cf81e7f"), Guid.Parse("c261445e-9675-4cbd-991f-65383ebcbb30"), requiredLevel: 10);
            builder.GainAnySkillFeat(Guid.Parse("2b43c235-4dd0-417d-960d-07c71ac41d4a"), Guid.Parse("eee2fdb6-6a56-4fe4-a61f-e83127ac6160"), requiredLevel: 12);
            builder.GainAnySkillFeat(Guid.Parse("190b31bd-312e-4095-b765-ccd8bc4ea6c8"), Guid.Parse("64d376ad-717d-494e-8a7b-51744b4c0ca4"), requiredLevel: 14);
            builder.GainAnySkillFeat(Guid.Parse("82282599-a8d9-4455-b424-cca67abf2c87"), Guid.Parse("1f03d793-56aa-426c-84fe-e328efa80215"), requiredLevel: 16);
            builder.GainAnySkillFeat(Guid.Parse("bf4786d1-bbe9-4004-8d5b-121340536194"), Guid.Parse("fb72fc0c-08da-420b-b680-09a549b1e844"), requiredLevel: 18);
            builder.GainAnySkillFeat(Guid.Parse("9b4e0e8f-ca0a-4353-b53b-62afba959dbb"), Guid.Parse("76dd0cfe-bc72-46a0-a32f-a68edb075cbf"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("385de42d-874e-4cc1-934b-172f384bd81b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 98
            };
        }
    }
}
