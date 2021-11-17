using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Swashbucklers
{
    public class AncestryFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("c9a80722-1475-4295-8e49-b92b39e99d7b");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 5,
                Name = "Ancestry Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7780c2c1-06c7-403e-81c6-7a4550271a9d"), Type = TextBlockType.Text, Text = "In addition to the ancestry feat you started with, you gain an ancestry feat at 5th level and every 4 levels thereafter." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAncestryFeat(Guid.Parse("98c5b1e5-092b-4552-ba30-1bb696dade1a"), Guid.Parse("568bfb9c-9c54-4cf2-bf99-0289904a1304"), requiredLevel: 5);
            builder.GainAnyAncestryFeat(Guid.Parse("7ce95ede-38f3-43ce-95b6-1436a7f0b81a"), Guid.Parse("08e84c0c-f15c-47e7-a28d-b71401f5d880"), requiredLevel: 9);
            builder.GainAnyAncestryFeat(Guid.Parse("982f4101-f087-49c4-9de1-7eb859f2ded5"), Guid.Parse("c811ec55-4edf-409a-9991-2a9a85cba7a3"), requiredLevel: 13);
            builder.GainAnyAncestryFeat(Guid.Parse("97e997d1-d4b6-4349-8bfb-a99d5bc20434"), Guid.Parse("2822388d-f74c-4001-a202-956817382e88"), requiredLevel: 17);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b5d474e9-d588-4243-b720-31fabea73070"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 86
            };
        }
    }
}
