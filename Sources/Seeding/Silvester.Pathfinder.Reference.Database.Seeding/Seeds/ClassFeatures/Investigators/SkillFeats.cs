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
    public class SkillFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("958b26a3-1fed-41a8-b435-9339f1bb78c0");

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
            yield return new TextBlock { Id = Guid.Parse("b787ca28-fed7-4b3c-af34-372195e24118"), Type = TextBlockType.Text, Text = "At 2nd level and every 2 levels thereafter, you gain a skill feat. Skill feats can be found in Chapter 5 of the Core Rulebook and have the skill trait. You must be trained or better in the corresponding skill to select a skill feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnySkillFeat(Guid.Parse("6893b75e-90af-4c86-a2d3-60d84a908d55"), Guid.Parse("eb95ed77-4d8b-494f-a021-d0e763fc0381"), requiredLevel: 2);
            builder.GainAnySkillFeat(Guid.Parse("00629c84-ace5-4899-ad57-0b609ab6a279"), Guid.Parse("701408ef-f478-49da-8626-5d46ec7b064f"), requiredLevel: 4);
            builder.GainAnySkillFeat(Guid.Parse("b760342e-75c3-469c-b9a4-df7c192d1588"), Guid.Parse("9cb051ee-8183-4667-b4c8-1bf15d591c04"), requiredLevel: 6);
            builder.GainAnySkillFeat(Guid.Parse("c55d7735-600a-47a2-9734-492696ed8d38"), Guid.Parse("0c636fa7-38d3-48e5-8a6e-ca3e47fa46e4"), requiredLevel: 8);
            builder.GainAnySkillFeat(Guid.Parse("699a3c2b-25b6-4436-b4b8-338a32cd4c13"), Guid.Parse("eddbe780-3acf-4c92-a527-a20715cd9f45"), requiredLevel: 10);
            builder.GainAnySkillFeat(Guid.Parse("ae5016b0-0a7c-4b06-8d70-940794159df1"), Guid.Parse("30e85eae-8ef2-4e63-8ad3-5b795a63d95c"), requiredLevel: 12);
            builder.GainAnySkillFeat(Guid.Parse("5e1b1844-a272-433d-96ef-6d75502cf0ff"), Guid.Parse("752aa61a-e68c-4d77-9423-269f6182792e"), requiredLevel: 14);
            builder.GainAnySkillFeat(Guid.Parse("c433450a-75ce-4eab-b8b7-ea2d6f2c2d52"), Guid.Parse("2c010df1-a380-47ea-8e78-04dc172e8e2d"), requiredLevel: 16);
            builder.GainAnySkillFeat(Guid.Parse("9d01548f-0f10-4e6a-9a79-d140b1d1fcb7"), Guid.Parse("4a9eac84-bfa8-417c-bd6e-d60fdf9e3d3a"), requiredLevel: 18);
            builder.GainAnySkillFeat(Guid.Parse("0cee7bf1-2df6-455e-8f2d-47a24d8f5fb8"), Guid.Parse("9e0153b4-b501-4d23-a1fe-57ec07843aa8"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("937ef929-c067-4072-ba80-ff23e3798860"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 59
            };
        }
    }
}
