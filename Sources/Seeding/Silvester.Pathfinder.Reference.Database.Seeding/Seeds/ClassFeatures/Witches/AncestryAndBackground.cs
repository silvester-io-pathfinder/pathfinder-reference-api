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
    public class AncestryAndBackground : Template
    {
        public static readonly Guid ID = Guid.Parse("8a79c7b7-fb92-4a0f-90ce-a78ae11d950f");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Ancestry and Background", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("46d58f68-7a8a-40f1-8547-d2cb67209e62"), Type = TextBlockType.Text, Text = "In addition to the abilities provided by your class at 1st level, you have the benefits of your selected ancestry and background, as described in Chapter 2 of the Core Rulebook." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyBackground(Guid.Parse("9d901d99-b052-4c77-8e56-48389457f943"));
            builder.GainAnyAncestryFeat(Guid.Parse("76756b1e-b713-488a-a044-101a9597de69"));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ffb7f5a1-f589-4362-b591-3e112baf8bf2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 96
            };
        }
    }
}
