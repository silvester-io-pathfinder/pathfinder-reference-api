using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Monks
{
    public class FuryOfBlows : Template
    {
        public static readonly Guid ID = Guid.Parse("74f52604-42fb-4f81-b3c0-2a1e1f81f932");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Fury of Blows", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("3b2f1ad6-0d22-40d3-b558-4a5b50835f7b"), Type = TextBlockType.Text, Text = "You can attack rapidly with fists, feet, elbows, knees, and other unarmed attacks. You gain the Flurry of Blows action." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("e7874168-4033-49ab-a2a2-0c99ec4dedf5"), Feats.Instances.FlurryOfBlows.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7cbcb465-d2dc-4b9e-aa90-42e2e882c3de"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 156
            };
        }
    }
}
