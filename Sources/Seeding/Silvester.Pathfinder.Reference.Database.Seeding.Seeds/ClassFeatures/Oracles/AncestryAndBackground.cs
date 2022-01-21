using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Oracles
{
    public class AncestryAndBackground : Template
    {
        public static readonly Guid ID = Guid.Parse("79ead689-b42e-47e4-bbb0-0d9efa3e6c3d");

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
            yield return new TextBlock { Id = Guid.Parse("7b900f4d-7f1f-4745-85b5-fe72fb542b61"), Type = TextBlockType.Text, Text = "In addition to the abilities provided by your class at 1st level, you have the benefits of your selected ancestry and background, as described in Chapter 2 of the Core Rulebook." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyBackground(Guid.Parse("52fee872-3db4-42a8-9058-0cbb48669c82"));
            builder.GainAnyAncestryFeat(Guid.Parse("f819dc1e-98d5-423a-9b81-a5bc1f6fb2d6"));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("014dfb94-73be-4a95-ad5f-0e2d2e40a2f1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 68
            };
        }
    }
}
