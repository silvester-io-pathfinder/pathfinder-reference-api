using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rangers
{
    public class SwiftPrey : Template
    {
        public static readonly Guid ID = Guid.Parse("bd46dd58-4650-4c5a-af5e-f06101a3d1e2");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 19,
                Name = "Swift Prey", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d7404524-e598-4dd8-a921-04c54ec72bce"), Type = TextBlockType.Text, Text = "You size up your prey with only a glance. You can use Hunt Prey as a free action if it's your first action of your turn." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f24b8449-07dd-4100-84ce-0a880ece71e1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 170
            };
        }
    }
}
