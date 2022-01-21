using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Alchemists
{
    public class AncestryFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("5da2c8e1-3d57-42eb-a5b8-77c4b4eb0f47");

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
            yield return new TextBlock { Id = Guid.Parse("9842a945-a405-44d0-b4a0-c0c9d06acff4"), Type = TextBlockType.Text, Text = "In addition to the ancestry feat you started with, you gain an ancestry feat at 5th level and every 4 levels thereafter." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAncestryFeat(Guid.Parse("a19969c4-d3ba-4f87-80bf-b43bad2c11fb"), Guid.Parse("c675d2ae-cdb2-4b9e-aa8c-563482755b53"), requiredLevel: 5);
            builder.GainAnyAncestryFeat(Guid.Parse("151aaa10-8485-4c7a-8d03-e7e66b54a117"), Guid.Parse("b89f10c2-b7e0-418c-af12-a20df8689dc7"), requiredLevel: 9);
            builder.GainAnyAncestryFeat(Guid.Parse("7baa7b20-f666-4e30-b2db-1f6f6013ad09"), Guid.Parse("f4a6317d-6336-482d-8154-7d37902b84e9"), requiredLevel: 13);
            builder.GainAnyAncestryFeat(Guid.Parse("dc8ebe0b-9828-46c0-9e2d-5366924a1771"), Guid.Parse("fa02e3cc-0fb5-4b73-8ca1-f42782819db5"), requiredLevel: 17);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("939768e3-ee43-4f5a-9c1a-13630b71190a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 74
            };
        }
    }
}
