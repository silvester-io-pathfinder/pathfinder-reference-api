using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Wizards
{
    public class SkillFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("512f6d40-36fe-4491-b2a1-64e4846310c6");

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
            yield return new TextBlock { Id = Guid.Parse("1fc7c2fa-4ac2-4828-a8b1-3e0796ab4791"), Type = TextBlockType.Text, Text = "At 2nd level and every 2 levels thereafter, you gain a skill feat. Skill feats can be found in Chapter 5 of the Core Rulebook and have the skill trait. You must be trained or better in the corresponding skill to select a skill feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnySkillFeat(Guid.Parse("a22e81ea-e976-4e14-81d1-5a8943f4e68a"), Guid.Parse("799638b6-9e81-4d1a-be27-108574d7b8e9"), requiredLevel: 2);
            builder.GainAnySkillFeat(Guid.Parse("d7e4bc07-0ba6-4ba3-815f-7db54eaa90ea"), Guid.Parse("c6b21ea0-4f27-4755-af05-72558e6e4af2"), requiredLevel: 4);
            builder.GainAnySkillFeat(Guid.Parse("ed1c7f82-1468-4f1b-af45-facbf3ede182"), Guid.Parse("662bb018-1cf2-45d5-9fa5-6c893f91ee6d"), requiredLevel: 6);
            builder.GainAnySkillFeat(Guid.Parse("8e8759b4-8456-4e43-9a46-f7767b1d9ccb"), Guid.Parse("3947d84b-0430-4efb-8b52-dd8fdffbb663"), requiredLevel: 8);
            builder.GainAnySkillFeat(Guid.Parse("91123aa7-f669-4803-a1e9-a1a05799c2e9"), Guid.Parse("3a7894dc-3710-49fa-9aa7-b4d135cc0adb"), requiredLevel: 10);
            builder.GainAnySkillFeat(Guid.Parse("b71ad176-5ce1-4ddd-84e5-e6389b03c0b2"), Guid.Parse("7f9bb2d3-14c4-4ad0-9590-905f5110495c"), requiredLevel: 12);
            builder.GainAnySkillFeat(Guid.Parse("9830c539-1338-4cf8-9857-fae23abf4463"), Guid.Parse("eb8de202-18b0-4f81-adba-c5e81ad5a2a5"), requiredLevel: 14);
            builder.GainAnySkillFeat(Guid.Parse("0add031a-14fb-4d42-959b-bec982e10e6d"), Guid.Parse("840f1ed9-3032-424a-ae79-1d2d315d1cf9"), requiredLevel: 16);
            builder.GainAnySkillFeat(Guid.Parse("15283087-ce3e-462b-8106-63e52dd3ded5"), Guid.Parse("3d9c2333-d5e2-44b9-90ce-67936040a1f9"), requiredLevel: 18);
            builder.GainAnySkillFeat(Guid.Parse("31e14339-7803-40e0-bf9e-85d8e77cdd39"), Guid.Parse("6c9e422f-d4b5-4349-a9d8-94b8bcf15a72"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("767fdc65-a5d9-4d0d-904b-498b21f145fe"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 206
            };
        }
    }
}
