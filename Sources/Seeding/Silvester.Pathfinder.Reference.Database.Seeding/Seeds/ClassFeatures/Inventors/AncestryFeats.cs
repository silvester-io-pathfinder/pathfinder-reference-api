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
    public class AncestryFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("57c1b6b5-50a7-47d4-8d0e-8cf8bc727997");

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
            yield return new TextBlock { Id = Guid.Parse("d0fd1c4d-20ae-4198-bf7d-05c94ce21742"), Type = TextBlockType.Text, Text = "In addition to the ancestry feat you started with, you gain an ancestry feat at 5th level and every 4 levels thereafter." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAncestryFeat(Guid.Parse("81a964db-68da-4f7c-9184-24cb4a9ecc9c"), Guid.Parse("9b82bd08-b116-4966-8480-3b7603d63724"), requiredLevel: 5);
            builder.GainAnyAncestryFeat(Guid.Parse("6a3f69dd-d677-44be-b8e5-e855a03edb45"), Guid.Parse("bca3b9cb-fd40-4673-8286-a2754875bb4a"), requiredLevel: 9);
            builder.GainAnyAncestryFeat(Guid.Parse("7c2bc3d6-d1b5-4cce-8b39-0fc50ca6289b"), Guid.Parse("3b5cfcca-0745-4f7c-af55-e5d32dfb63b9"), requiredLevel: 13);
            builder.GainAnyAncestryFeat(Guid.Parse("839230da-bdc6-4378-b1fd-bdd23fcb2143"), Guid.Parse("a5403274-f9a6-46fb-94bc-26da6f454133"), requiredLevel: 17);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("565bcfb5-4a5d-4f77-b812-5567e1255e13"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 20
            };
        }
    }
}
