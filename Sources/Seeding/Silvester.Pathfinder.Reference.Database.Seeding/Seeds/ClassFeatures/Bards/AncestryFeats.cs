using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Bards
{
    public class AncestryFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("f610e1b7-f549-484f-97fa-4dd91cdc0899");

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
            yield return new TextBlock { Id = Guid.Parse("254f5f6e-8192-4d30-b94a-8c6c0fbedee5"), Type = TextBlockType.Text, Text = "In addition to the ancestry feat you started with, you gain an ancestry feat at 5th level and every 4 levels thereafter." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAncestryFeat(Guid.Parse("6c87d516-27d5-44e8-b167-f395bf6d925a"), Guid.Parse("f369274d-780d-4d57-a1ec-692571b5a81b"), requiredLevel: 5);
            builder.GainAnyAncestryFeat(Guid.Parse("66de9c02-205b-4b22-b441-48c7c17cbb04"), Guid.Parse("d94c7534-c4ca-4bf1-a4e3-bbf0d61bab6d"), requiredLevel: 9);
            builder.GainAnyAncestryFeat(Guid.Parse("5b93e262-6576-4429-92a6-38e2fc6a13d5"), Guid.Parse("c9afb217-e444-4221-b06b-9b650e1b0702"), requiredLevel: 13);
            builder.GainAnyAncestryFeat(Guid.Parse("d5d315fe-916a-426b-88b5-290d9e065bea"), Guid.Parse("d55ffc94-df41-4ed3-bb31-9401102d9d9b"), requiredLevel: 17);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4b76ea41-370e-44bd-8dda-eb0c4e1f99ca"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 98
            };
        }
    }
}
