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
    public class AncestryFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("bef8aa27-9a77-4218-bc54-d9b752ceacb0");

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
            yield return new TextBlock { Id = Guid.Parse("8947780c-ce32-4014-bfd7-94863c77d915"), Type = TextBlockType.Text, Text = "In addition to the ancestry feat you started with, you gain an ancestry feat at 5th level and every 4 levels thereafter." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAncestryFeat(Guid.Parse("f0cc50a6-3f1b-4e96-b428-cdfdd4644b09"), Guid.Parse("7f565d78-b943-45dd-b061-f4d08dbae191"), requiredLevel: 5);
            builder.GainAnyAncestryFeat(Guid.Parse("021d0b79-7b75-4086-8bcc-b39184185f94"), Guid.Parse("3a4559a7-00ca-4fec-ab4f-0cd69bb9f95e"), requiredLevel: 9);
            builder.GainAnyAncestryFeat(Guid.Parse("2554f0af-3477-419c-898c-31e991c6d460"), Guid.Parse("69433856-97b1-466b-8526-573ebf4851ec"), requiredLevel: 13);
            builder.GainAnyAncestryFeat(Guid.Parse("738d63e8-d81b-45fd-ac26-c3ea17ca92a5"), Guid.Parse("8a6e7000-ee5e-4033-976e-04437626282b"), requiredLevel: 17);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4bbcdb0c-9c1b-4ed6-bfdd-9e6f5d862026"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 107
            };
        }
    }
}
