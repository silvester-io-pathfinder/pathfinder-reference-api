using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rogues
{
    public class GeneralFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("a766583a-db82-4bf0-9618-1f6b7dae3600");

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
            yield return new TextBlock { Id = Guid.Parse("149dde9c-8a59-443e-8504-446aefd3e02c"), Type = TextBlockType.Text, Text = "At 3rd level and every 4 levels thereafter, you gain a general feat. General feats are listed in Chapter 5." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyGeneralFeat(Guid.Parse("e52944b8-f178-46fa-bf54-194b43b6fcd0"), Guid.Parse("53944223-71af-4be8-b90f-67f91995ba38"), requiredLevel: 3);
            builder.GainAnyGeneralFeat(Guid.Parse("c5dc8495-f3fd-4f6a-9df2-fe9972eec605"), Guid.Parse("af5a680d-d548-4f51-b157-1e164fe8f3be"), requiredLevel: 7);
            builder.GainAnyGeneralFeat(Guid.Parse("2a3b6903-1a02-4630-9532-2190ed9a20dc"), Guid.Parse("e0ded0c7-5f83-40dc-86a2-619151356392"), requiredLevel: 11);
            builder.GainAnyGeneralFeat(Guid.Parse("a349709b-14d2-4052-91f4-2636bd6c40e1"), Guid.Parse("b7b4684f-6176-405e-a68a-0dd2eb937176"), requiredLevel: 15);
            builder.GainAnyGeneralFeat(Guid.Parse("8d0c3a9c-33d8-4f8d-b368-c2aa15303f00"), Guid.Parse("61b44db0-1017-4558-adf9-bb7f72008563"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("11cd7015-72b9-4cae-8ab8-df3ff0fe1539"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 181
            };
        }
    }
}
