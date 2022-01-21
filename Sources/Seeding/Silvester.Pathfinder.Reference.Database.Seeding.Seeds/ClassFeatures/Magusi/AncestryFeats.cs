using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Magusi
{
    public class AncestryFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("7604790d-7e6e-4807-b06f-9fc02dc2ccf0");

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
            yield return new TextBlock { Id = Guid.Parse("7197593f-e7e1-4be6-9fbf-8600087faaf7"), Type = TextBlockType.Text, Text = "In addition to the ancestry feat you started with, you gain an ancestry feat at 5th level and every 4 levels thereafter." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAncestryFeat(Guid.Parse("fa225535-dc3d-41e8-b896-dcd2c50a2e4d"), Guid.Parse("a64af2d7-dbb8-4b5d-8317-924a8037546a"), requiredLevel: 5);
            builder.GainAnyAncestryFeat(Guid.Parse("bdbc5403-558c-4f0e-8077-1ef8cff4ca67"), Guid.Parse("0030a31f-6c58-43ee-8f85-2611a1ca4389"), requiredLevel: 9);
            builder.GainAnyAncestryFeat(Guid.Parse("93ed511a-bed6-4ae8-b6ab-892f0e3cd3eb"), Guid.Parse("c5a2e87a-472a-43ab-84c7-7751ecfe10e4"), requiredLevel: 13);
            builder.GainAnyAncestryFeat(Guid.Parse("71dab61e-ec7c-488c-a19f-843f2d3422a2"), Guid.Parse("5f332322-b8b4-4f8a-be51-7fbbf44fcf87"), requiredLevel: 17);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("185408bc-fd0e-4016-a65b-99ecf8e81447"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 40
            };
        }
    }
}
