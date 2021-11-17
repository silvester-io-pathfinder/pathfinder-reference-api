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
    public class GeneralFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("13e19fbe-c483-40b7-a9ea-4ac8b0099932");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 3,
                Name = "General Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2838d876-a6d2-4143-8755-b6117836c13b"), Type = TextBlockType.Text, Text = "At 3rd level and every 4 levels thereafter, you gain a general feat. General feats are listed in Chapter 5." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyGeneralFeat(Guid.Parse("9dfc13c1-d76d-46e9-b193-08b7452ecee3"), Guid.Parse("bd771962-7059-4afd-b0b4-43bebef4b4e7"), requiredLevel: 3);
            builder.GainAnyGeneralFeat(Guid.Parse("250d2ad6-5d42-48fb-8168-17bf03825bf0"), Guid.Parse("191a74b3-eaa7-42e0-996a-b1f6c4336d80"), requiredLevel: 7);
            builder.GainAnyGeneralFeat(Guid.Parse("edc462cc-bd19-4daa-8c6f-ddc879dada68"), Guid.Parse("f5d0a54d-3dac-4f53-8d18-a120561dfb9d"), requiredLevel: 11);
            builder.GainAnyGeneralFeat(Guid.Parse("327419f6-7a83-4fe0-a613-72e1e822e3e5"), Guid.Parse("6f3e2c04-ffd5-4d8e-b548-352b202b6fe5"), requiredLevel: 15);
            builder.GainAnyGeneralFeat(Guid.Parse("cf9b2a43-eb53-495a-b521-cb39d989864a"), Guid.Parse("7d782ab1-1776-4606-8bf3-134d9c8053ab"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1fffc56d-d7e2-429f-ad26-7db885338b0f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 132
            };
        }
    }
}
