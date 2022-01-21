using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Witches
{
    public class SkillFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("7069fd6c-a797-4cbb-b394-9fddd24b55f7");

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
            yield return new TextBlock { Id = Guid.Parse("41150b0e-326a-4319-940d-ce23c6868e76"), Type = TextBlockType.Text, Text = "At 2nd level and every 2 levels thereafter, you gain a skill feat. Skill feats can be found in Chapter 5 of the Core Rulebook and have the skill trait. You must be trained or better in the corresponding skill to select a skill feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnySkillFeat(Guid.Parse("0754d29a-3228-475d-92d5-1cfe045f7747"), Guid.Parse("d69b7f7f-2940-4108-8ed7-33bc205d873e"), requiredLevel: 2);
            builder.GainAnySkillFeat(Guid.Parse("a666c774-c624-4b31-8e3a-837e5bbcaa48"), Guid.Parse("9fcb8a73-6971-4425-833a-0ef1102f1f20"), requiredLevel: 4);
            builder.GainAnySkillFeat(Guid.Parse("510e2686-766f-4b8c-8300-d73bd94f0fa8"), Guid.Parse("e321366d-48a6-4b17-946b-d3960018dc9c"), requiredLevel: 6);
            builder.GainAnySkillFeat(Guid.Parse("5fae7dde-be44-4870-85b1-f130656dc6a0"), Guid.Parse("5549aec5-5695-4ac2-89c3-14cc37357ab2"), requiredLevel: 8);
            builder.GainAnySkillFeat(Guid.Parse("f6be0fe6-64db-47f2-aa77-c5d2233946b0"), Guid.Parse("913352d1-308f-4ac5-a908-900bdfeafb53"), requiredLevel: 10);
            builder.GainAnySkillFeat(Guid.Parse("acc3e919-e19a-447d-8bf7-4d7531438343"), Guid.Parse("7e2d09d8-3d78-4c15-a735-427c31c928ff"), requiredLevel: 12);
            builder.GainAnySkillFeat(Guid.Parse("057b866e-7b98-4d79-9162-a63125da7393"), Guid.Parse("af77e286-d807-4761-8839-2dfc0c5251d2"), requiredLevel: 14);
            builder.GainAnySkillFeat(Guid.Parse("ade3f254-7577-4b52-8919-89adcb8b38b1"), Guid.Parse("2bdc8073-2a07-485c-a3a8-2f77d6ebb36f"), requiredLevel: 16);
            builder.GainAnySkillFeat(Guid.Parse("afc311eb-aa04-4e89-a6c5-c55c99bc1ec2"), Guid.Parse("72104100-acce-43b2-a621-89d1fcbf7a7d"), requiredLevel: 18);
            builder.GainAnySkillFeat(Guid.Parse("d0cb6dcd-0ef9-437e-bb1d-e92c35a8fd0a"), Guid.Parse("5692b2c8-21fe-4367-bb3e-861644339e29"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5f0cb593-f666-44bc-a8f4-dba9c57abe74"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 98
            };
        }
    }
}
