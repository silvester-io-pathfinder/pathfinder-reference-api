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
    public class GeneralFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("1c457086-441b-4a6f-8568-aa079d8e3faa");

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
            yield return new TextBlock { Id = Guid.Parse("46269ff0-9979-4890-b0cf-460fe222e93f"), Type = TextBlockType.Text, Text = "At 3rd level and every 4 levels thereafter, you gain a general feat. General feats are listed in Chapter 5." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyGeneralFeat(Guid.Parse("9ecc1048-db47-4d30-a887-8fbe79bf3e2f"), Guid.Parse("3cce5d8a-9056-4bce-91e4-196ee0dedcb7"), requiredLevel: 3);
            builder.GainAnyGeneralFeat(Guid.Parse("30913274-2ac4-490b-a1f2-dfaf820f1804"), Guid.Parse("7e64dc20-094a-4556-a86e-02cc3a2c581a"), requiredLevel: 7);
            builder.GainAnyGeneralFeat(Guid.Parse("689f228b-c628-4092-b3e6-6533a4e10493"), Guid.Parse("a6eea2c5-814e-400e-8781-1ad11cc3ac20"), requiredLevel: 11);
            builder.GainAnyGeneralFeat(Guid.Parse("55b00b79-cb8c-48a3-a626-f365d94f3659"), Guid.Parse("062bc81b-8449-46e1-8125-4b78eba5ea4f"), requiredLevel: 15);
            builder.GainAnyGeneralFeat(Guid.Parse("3e788211-b975-4339-a43c-1fcb1a698993"), Guid.Parse("7331dc52-8372-425a-8c4b-ad90f16ab424"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d9fe55d4-7639-49db-a8cf-b7f498a0526c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 74
            };
        }
    }
}
