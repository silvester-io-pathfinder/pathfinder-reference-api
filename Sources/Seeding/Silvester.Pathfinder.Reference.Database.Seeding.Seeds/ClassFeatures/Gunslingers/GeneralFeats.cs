using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Gunslingers
{
    public class GeneralFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("c99fc2ee-4803-4903-a43a-d8d26c0d3d8b");

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
            yield return new TextBlock { Id = Guid.Parse("40b47478-48ac-409e-8eb7-f223e88c7ed5"), Type = TextBlockType.Text, Text = "At 3rd level and every 4 levels thereafter, you gain a general feat. General feats are listed in Chapter 5." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyGeneralFeat(Guid.Parse("72945c96-6735-42d4-a722-1ea50e3c7a35"), Guid.Parse("26e480fd-361c-4ba9-b049-4ed659a30699"), requiredLevel: 3);
            builder.GainAnyGeneralFeat(Guid.Parse("24290c7d-62b4-4165-9194-d1c0a8bcbebb"), Guid.Parse("773c3575-884e-4c87-a21a-afe27252e39c"), requiredLevel: 7);
            builder.GainAnyGeneralFeat(Guid.Parse("61972f65-f719-4cd1-8ac1-a49f8ac404e9"), Guid.Parse("e66c58b5-8e39-40e1-830f-c89166e86e0f"), requiredLevel: 11);
            builder.GainAnyGeneralFeat(Guid.Parse("a9b2cf23-f3fc-4b42-9ed2-627077c099a3"), Guid.Parse("4966d628-96a2-4fce-8617-2210d104e02c"), requiredLevel: 15);
            builder.GainAnyGeneralFeat(Guid.Parse("84ff5dba-c39f-4e01-86b3-4ebffd1302ab"), Guid.Parse("c1888dd4-e178-45c3-87d1-f11dc737449d"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b173e7f3-b6b6-48eb-acbb-27d256aec1d9"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 106
            };
        }
    }
}
