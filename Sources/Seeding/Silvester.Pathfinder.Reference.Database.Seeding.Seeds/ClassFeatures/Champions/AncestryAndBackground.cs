using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Champions
{
    public class AncestryAndBackground : Template
    {
        public static readonly Guid ID = Guid.Parse("a7a7b3b3-2ae3-4bfb-9821-a5c456184b8c");

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
            yield return new TextBlock { Id = Guid.Parse("326adf21-4bac-44ef-a322-a88e28543892"), Type = TextBlockType.Text, Text = "In addition to the abilities provided by your class at 1st level, you have the benefits of your selected ancestry and background, as described in Chapter 2 of the Core Rulebook." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyBackground(Guid.Parse("32d3f74f-6c12-445f-813e-acc2aabe50f0"));
            builder.GainAnyAncestryFeat(Guid.Parse("57ce0136-bf09-436a-a875-5e95e1d27052"));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("84fd07bb-ed95-4992-9472-79cec4699e90"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 106
            };
        }
    }
}
