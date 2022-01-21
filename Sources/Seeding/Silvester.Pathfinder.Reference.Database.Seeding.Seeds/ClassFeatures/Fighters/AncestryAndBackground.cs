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
    public class AncestryAndBackground : Template
    {
        public static readonly Guid ID = Guid.Parse("c6befa9a-ac12-4143-96cc-d7a29c5c9f6e");

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
            yield return new TextBlock { Id = Guid.Parse("fddb7a66-b187-4f28-9ef0-cc28e3fc4f39"), Type = TextBlockType.Text, Text = "In addition to the abilities provided by your class at 1st level, you have the benefits of your selected ancestry and background, as described in Chapter 2 of the Core Rulebook." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyBackground(Guid.Parse("b63d3e5e-a386-440d-954c-beec7225c5f0"));
            builder.GainAnyAncestryFeat(Guid.Parse("fb83d7ea-7ee5-41bb-a51e-ab4ffe9f4cc9"));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f622536f-7f01-4b9d-bf22-ecd64024a91c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 142
            };
        }
    }
}
