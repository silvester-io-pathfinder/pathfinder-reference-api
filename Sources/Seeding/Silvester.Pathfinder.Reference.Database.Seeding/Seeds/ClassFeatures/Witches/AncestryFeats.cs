using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Witches
{
    public class AncestryFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("624ea4aa-e421-4db7-9097-c02332b2ddba");

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
            yield return new TextBlock { Id = Guid.Parse("7c53a6ae-7410-4a8b-8593-acf7d303d066"), Type = TextBlockType.Text, Text = "In addition to the ancestry feat you started with, you gain an ancestry feat at 5th level and every 4 levels thereafter." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAncestryFeat(Guid.Parse("d038c353-423f-4482-bfe9-57c72fde4153"), Guid.Parse("37256751-cb33-4d0d-8ebc-918170c9e6b3"), requiredLevel: 5);
            builder.GainAnyAncestryFeat(Guid.Parse("9b5e7464-ef96-419e-8f31-078340fa8039"), Guid.Parse("d82881de-38c4-4de8-a4a4-30d34ed16432"), requiredLevel: 9);
            builder.GainAnyAncestryFeat(Guid.Parse("aeb53ef5-6ba1-493c-9f13-cfb1c88039ae"), Guid.Parse("9105d958-1e08-4be1-9570-74b1ffb041d7"), requiredLevel: 13);
            builder.GainAnyAncestryFeat(Guid.Parse("7dfc8880-9b53-4e58-95ea-183680e26a31"), Guid.Parse("ca67b656-3d71-4bea-95de-25607a77d289"), requiredLevel: 17);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ac4f764e-080c-4e2b-b7c3-f487e5db62b7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 98
            };
        }
    }
}
