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
    public class AdvancedDeed : Template
    {
        public static readonly Guid ID = Guid.Parse("cd8f9dea-b79e-4889-adba-46387aab567b");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 9,
                Name = "Advanced Deed", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f3f7a9d9-2e36-4778-9c3c-9fa243162f35"), Type = TextBlockType.Text, Text = "You've learned a powerful new technique of your chosen way. You gain the advanced deed ability of the way you chose at 1st level." };
            yield return new TextBlock { Id = Guid.Parse("c6b5e46f-db2e-42d1-9cb8-2247dcc5e3e4"), Type = TextBlockType.Footnote, Text = "The Class Feature's effects are handled by the Gunslinger's Way." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c53b236e-d0de-41b5-b164-a4ac9495650f"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 107
            };
        }
    }
}
