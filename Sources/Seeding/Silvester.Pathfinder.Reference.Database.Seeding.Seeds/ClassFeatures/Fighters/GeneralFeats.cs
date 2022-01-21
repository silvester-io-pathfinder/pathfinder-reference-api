using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Fighters
{
    public class GeneralFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("775c1230-4926-422a-8a49-8f0b2091fdd7");

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
            yield return new TextBlock { Id = Guid.Parse("eb594c48-5289-4d35-815e-b83b0b7e48d3"), Type = TextBlockType.Text, Text = "At 3rd level and every 4 levels thereafter, you gain a general feat. General feats are listed in Chapter 5." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyGeneralFeat(Guid.Parse("509f4943-ba03-45ed-8f79-db9cd36f1e75"), Guid.Parse("aad1ba23-3ede-4d6c-a2c2-c9d26b22a224"), requiredLevel: 3);
            builder.GainAnyGeneralFeat(Guid.Parse("648a5c2e-a6d1-4b47-82fb-22be5c12cb78"), Guid.Parse("67b0ac34-70cf-4c2e-a6b0-4dc316dcfbd6"), requiredLevel: 7);
            builder.GainAnyGeneralFeat(Guid.Parse("f2f95e95-c219-4601-a8f2-9872c688be97"), Guid.Parse("0c37382b-c55a-43c1-82d5-da86d889afbc"), requiredLevel: 11);
            builder.GainAnyGeneralFeat(Guid.Parse("47e31cbc-84ff-4e8a-aaae-f78ba164f35c"), Guid.Parse("0eb0200e-35b0-404c-816f-b1676a35d753"), requiredLevel: 15);
            builder.GainAnyGeneralFeat(Guid.Parse("39c80f94-3dcf-4342-8d31-854672a5396b"), Guid.Parse("9be6672b-3e9b-4f56-aecc-f872255f750e"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a78a1f2a-ee30-43fd-a7a2-a1435255f428"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 142
            };
        }
    }
}
