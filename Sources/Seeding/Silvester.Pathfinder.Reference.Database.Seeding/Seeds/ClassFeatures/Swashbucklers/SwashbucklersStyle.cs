using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Swashbucklers
{
    public class SwashbucklersStyle : Template
    {
        public static readonly Guid ID = Guid.Parse("b7b75a2c-c590-4f04-8b1e-4d7241cff6b0");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Swashbucklers Style", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("24226cfb-d630-4137-925a-3d3cef087805"), Type = TextBlockType.Text, Text = "As a swashbuckler, you have your own distinctive style that enables you to gracefully handle everyday events and life-or- death situations alike. Choose a swashbuckler's style. This style determines the additional actions you use to gain panache and makes you trained in the skill related to that action." };

        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnySwashbucklersStyle(Guid.Parse("8f901e61-fd91-472b-a5be-a98bdc7f3db4"));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c845578f-0e79-405f-b2f0-08d51f8cb300"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 84
            };
        }
    }
}
