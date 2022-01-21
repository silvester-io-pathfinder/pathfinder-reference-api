using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Inventors
{
    public class GeneralFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("d0fa448c-1b49-4b0d-981f-5b9bda3d8b7e");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 3,
                Name = "General Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("0cc0eae1-2c05-4660-8413-328f2de8e14f"), Type = TextBlockType.Text, Text = "At 3rd level and every 4 levels thereafter, you gain a general feat. General feats are listed in Chapter 5." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyGeneralFeat(Guid.Parse("5a0b1517-f494-49d7-835d-7d682c3ecc9a"), Guid.Parse("840ac7da-8529-4de5-9340-15fe0dfbc4a9"), requiredLevel: 3);
            builder.GainAnyGeneralFeat(Guid.Parse("23617467-16ce-4b48-8371-c92f08d298bf"), Guid.Parse("a02b8fd0-8623-441d-8e14-88e3f1479811"), requiredLevel: 7);
            builder.GainAnyGeneralFeat(Guid.Parse("998bedb5-28c5-4c8c-bee5-54fa0d47ddd4"), Guid.Parse("ca77ad8a-0873-4a9d-afe9-b9d221d6849f"), requiredLevel: 11);
            builder.GainAnyGeneralFeat(Guid.Parse("e1d973d6-e6a3-42c1-9fcb-d97620ea2737"), Guid.Parse("b78ac63e-314e-4108-9121-2903e20b9f80"), requiredLevel: 15);
            builder.GainAnyGeneralFeat(Guid.Parse("147bde99-1fab-4753-a5c6-1036988190b3"), Guid.Parse("1dc8bb50-30ab-4d3e-90d7-8bae09ef855b"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4d075e85-208f-4f96-9100-edadfa9d76a5"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 20
            };
        }
    }
}
