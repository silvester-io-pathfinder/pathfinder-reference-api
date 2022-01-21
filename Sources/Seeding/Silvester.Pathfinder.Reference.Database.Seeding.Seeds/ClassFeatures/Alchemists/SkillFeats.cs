using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Alchemists
{
    public class SkillFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("54bfb7c0-0671-495d-8c70-c72a42a805e9");

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
            yield return new TextBlock { Id = Guid.Parse("0083e41c-a563-4e68-bb06-d4ce35030744"), Type = TextBlockType.Text, Text = "At 2nd level and every 2 levels thereafter, you gain a skill feat. Skill feats can be found in Chapter 5 of the Core Rulebook and have the skill trait. You must be trained or better in the corresponding skill to select a skill feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnySkillFeat(Guid.Parse("3628eced-5f5f-4a9f-b7d6-c8a85b7b92d1"), Guid.Parse("3f5d7697-9b74-48ab-ac56-c9681239f1c7"), requiredLevel: 2);
            builder.GainAnySkillFeat(Guid.Parse("e8251ca4-5126-487a-8651-9316c586fde8"), Guid.Parse("21522cc9-8565-4355-afea-19c2a5823a38"), requiredLevel: 4);
            builder.GainAnySkillFeat(Guid.Parse("4c6ea66b-0ac4-460f-9f9b-a2d9e3b9c1c2"), Guid.Parse("41ec6e55-290a-41c2-b802-852def0c2447"), requiredLevel: 6);
            builder.GainAnySkillFeat(Guid.Parse("4373d55b-d6c3-47ae-82a8-ec38b387bc35"), Guid.Parse("94d42cf3-d1ee-4cca-ad02-da2c9c2047cb"), requiredLevel: 8);
            builder.GainAnySkillFeat(Guid.Parse("036ccd46-583f-4aa5-a2c5-ea31b7c44dd9"), Guid.Parse("5cbdb8ba-2a7d-47c1-8bd7-743437111401"), requiredLevel: 10);
            builder.GainAnySkillFeat(Guid.Parse("68d61380-22f5-43d2-bbd4-16cc723304c5"), Guid.Parse("0188a6b4-bf6b-4049-a078-9a13a56fd84c"), requiredLevel: 12);
            builder.GainAnySkillFeat(Guid.Parse("2c6d764e-f33f-47cd-a6cf-d2c6e64d042e"), Guid.Parse("7b60459b-80fd-4814-945a-93c2230aff38"), requiredLevel: 14);
            builder.GainAnySkillFeat(Guid.Parse("3543d029-194f-431d-b50f-6a208db0409a"), Guid.Parse("ec0316d1-1451-4274-b726-a7e625bf9d25"), requiredLevel: 16);
            builder.GainAnySkillFeat(Guid.Parse("aca05fd6-d8e8-420d-9903-eb2fa7c371af"), Guid.Parse("b2e1cacc-a45a-4ac2-8a4f-d2ac6aae722e"), requiredLevel: 18);
            builder.GainAnySkillFeat(Guid.Parse("0db366f5-7eba-4587-912f-b0fba0ab2767"), Guid.Parse("2a172724-4025-4735-807c-eee1a62479f1"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("90ce77e9-5dca-4f9b-9873-0820e4df9f1d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 73
            };
        }
    }
}
