using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Monks
{
    public class AncestryFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("cd042bd0-0c76-40bd-89dc-553713a93bbc");

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
            yield return new TextBlock { Id = Guid.Parse("3973aafd-8440-41c1-a3cf-765bfffd977f"), Type = TextBlockType.Text, Text = "In addition to the ancestry feat you started with, you gain an ancestry feat at 5th level and every 4 levels thereafter." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAncestryFeat(Guid.Parse("3b9f391d-7f4e-4603-9ef4-5c0d4a53ff02"), Guid.Parse("ad2dec45-9d87-4b92-b866-d55fb9b3d463"), requiredLevel: 5);
            builder.GainAnyAncestryFeat(Guid.Parse("c2da3f98-973e-4ba3-9068-379212af0b38"), Guid.Parse("786ce89f-785a-43ac-8f92-bbe406fc5c59"), requiredLevel: 9);
            builder.GainAnyAncestryFeat(Guid.Parse("7007694a-d714-43ec-94ea-bb6f0bdf4cc5"), Guid.Parse("cb11932c-2e16-4a26-9802-21168cbe6c60"), requiredLevel: 13);
            builder.GainAnyAncestryFeat(Guid.Parse("1c53e89e-c585-4d17-a69e-24a3930c706f"), Guid.Parse("7cc70296-3316-4556-8f64-f11a59cdcffc"), requiredLevel: 17);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("927dae77-1951-44ec-a83c-987867b2b2d5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 157
            };
        }
    }
}
