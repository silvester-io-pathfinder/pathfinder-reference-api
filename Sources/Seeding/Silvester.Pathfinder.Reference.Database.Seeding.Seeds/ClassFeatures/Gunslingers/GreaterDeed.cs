using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Gunslingers
{
    public class GreaterDeed : Template
    {
        public static readonly Guid ID = Guid.Parse("0a393bd0-64b8-42f1-98dc-6842fd46a6af");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 15,
                Name = "Greater Deed", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ef4d024a-e79e-416a-9ea5-92148d3e9f41"), Type = TextBlockType.Text, Text = "You've mastered the pinnacle technique of your chosen way. You gain the greater deed ability of the way you chose at 1st level." };
            yield return new TextBlock { Id = Guid.Parse("0433bc1d-c028-4a3d-b0dc-c755c2bb20e6"), Type = TextBlockType.Footnote, Text = "The Class Feature's effects are handled by the Gunslinger's Way." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a5ac433c-4d95-47ec-b454-e3586877d404"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 107
            };
        }
    }
}
