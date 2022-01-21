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
    public class GeneralFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("eb66a4e2-5f13-4241-bd63-fba4e61dc2c6");

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
            yield return new TextBlock { Id = Guid.Parse("f37b319d-ad15-4de3-9f97-08c1253b66d3"), Type = TextBlockType.Text, Text = "At 3rd level and every 4 levels thereafter, you gain a general feat. General feats are listed in Chapter 5." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyGeneralFeat(Guid.Parse("f6548045-475c-4d8c-b3ed-cb0dfb34940b"), Guid.Parse("89f65b60-df6a-49f9-a1f7-54681ee30c9f"), requiredLevel: 3);
            builder.GainAnyGeneralFeat(Guid.Parse("09df3fcc-fa95-4a78-9d85-761ca9d91254"), Guid.Parse("8a003cf6-927d-43fd-94e4-c534f7dd629f"), requiredLevel: 7);
            builder.GainAnyGeneralFeat(Guid.Parse("1dd98ead-c745-45fa-95ce-4a1567817718"), Guid.Parse("ed8a8fa4-50fc-4e1c-a6ba-dc5e1105e98b"), requiredLevel: 11);
            builder.GainAnyGeneralFeat(Guid.Parse("707965bf-2976-40b8-8623-a980b6a416b1"), Guid.Parse("d7b42a31-e4a9-4532-a47a-72958f7a1ae1"), requiredLevel: 15);
            builder.GainAnyGeneralFeat(Guid.Parse("9e3031db-baa5-4266-a785-b2a60f6ecf31"), Guid.Parse("d3d7dc66-28fa-4fc8-a744-6385132dfa2b"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a636d9c4-a243-4f52-8295-4d736703a6d5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 98
            };
        }
    }
}
