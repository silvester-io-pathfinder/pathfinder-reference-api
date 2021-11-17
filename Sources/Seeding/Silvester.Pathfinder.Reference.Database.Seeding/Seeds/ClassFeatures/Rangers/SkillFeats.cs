using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rangers
{
    public class SkillFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("0e28e9b5-e575-42fe-ba4d-b1fe4f4c5846");

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
            yield return new TextBlock { Id = Guid.Parse("37e96c10-dcb7-4d31-aebb-1f29fe247785"), Type = TextBlockType.Text, Text = "At 2nd level and every 2 levels thereafter, you gain a skill feat. Skill feats can be found in Chapter 5 of the Core Rulebook and have the skill trait. You must be trained or better in the corresponding skill to select a skill feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnySkillFeat(Guid.Parse("773eb518-37c3-439d-bf54-95393c519a8c"), Guid.Parse("3bd57397-a81a-45e7-a453-f78a87bdc6d9"), requiredLevel: 2);
            builder.GainAnySkillFeat(Guid.Parse("190e91f9-7f83-45b9-8f8b-5e7a95dc43c0"), Guid.Parse("6c62a7fd-4ea8-425a-a488-2043c9fa344b"), requiredLevel: 4);
            builder.GainAnySkillFeat(Guid.Parse("67282d6b-430c-42be-b2f6-d0a9130f4dd8"), Guid.Parse("0eaa9658-0708-4be2-8b1d-bc4ec33e3f4d"), requiredLevel: 6);
            builder.GainAnySkillFeat(Guid.Parse("0b4dc792-0e05-4c9c-8a4e-f90003bf616c"), Guid.Parse("15f4c1cb-f0b2-428b-a563-8504e0fdadc5"), requiredLevel: 8);
            builder.GainAnySkillFeat(Guid.Parse("33a9bf89-8a5f-4eec-924e-bf1aec81d6e5"), Guid.Parse("129bc37e-03fa-4b85-8e6b-49ed94b3a075"), requiredLevel: 10);
            builder.GainAnySkillFeat(Guid.Parse("9512aa44-aa03-4e12-a2c6-a49bee665ae0"), Guid.Parse("53b9b2e3-4a1f-4dde-91b4-09ffb75b5677"), requiredLevel: 12);
            builder.GainAnySkillFeat(Guid.Parse("d4af36eb-2691-4e35-b733-61739742d694"), Guid.Parse("99b73c11-8e6a-4758-9756-d37a7a53f2c1"), requiredLevel: 14);
            builder.GainAnySkillFeat(Guid.Parse("3003bbb0-8d48-413d-83ff-8d57d175560b"), Guid.Parse("70652ade-1d3b-4475-9057-ac190ee0110e"), requiredLevel: 16);
            builder.GainAnySkillFeat(Guid.Parse("08883cef-041f-4d50-bc6d-032a3dc52b29"), Guid.Parse("689d1e95-7b69-42ff-9170-45f3f0125b67"), requiredLevel: 18);
            builder.GainAnySkillFeat(Guid.Parse("d8ac8358-ee51-4bd3-9b4a-131e44c4b59a"), Guid.Parse("13ec9abf-2d46-42b1-82e5-87ca32fa7b3b"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8c8255ab-6311-4e52-a378-60df1b975bf8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 168
            };
        }
    }
}
