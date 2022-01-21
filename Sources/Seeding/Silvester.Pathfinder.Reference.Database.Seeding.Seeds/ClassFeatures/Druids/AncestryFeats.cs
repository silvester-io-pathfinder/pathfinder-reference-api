using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Druids
{
    public class AncestryFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("8e6619da-1dfa-4b31-b027-17cfe9b534e2");

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
            yield return new TextBlock { Id = Guid.Parse("e0524a60-731e-4573-95ae-3dd14c6fb189"), Type = TextBlockType.Text, Text = "In addition to the ancestry feat you started with, you gain an ancestry feat at 5th level and every 4 levels thereafter." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAncestryFeat(Guid.Parse("3a829d0a-4dfa-4505-b044-0643fc3e91a4"), Guid.Parse("374a3d2f-97ef-481f-8436-4d0c35a1b3bc"), requiredLevel: 5);
            builder.GainAnyAncestryFeat(Guid.Parse("d98c0409-08fe-424f-913c-79b45b49bbd1"), Guid.Parse("b634f7f7-d851-4d7d-aeaf-9285c02946b5"), requiredLevel: 9);
            builder.GainAnyAncestryFeat(Guid.Parse("0d0d00a9-08eb-46af-9897-e1ac76961cba"), Guid.Parse("9526a7b7-d1f1-47a9-85a1-996feb1a78ee"), requiredLevel: 13);
            builder.GainAnyAncestryFeat(Guid.Parse("b5ee1032-d233-4615-8747-b8794776347f"), Guid.Parse("52890da9-37d8-438a-bd03-30585f0f9627"), requiredLevel: 17);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c56f2d9b-1533-4c68-b116-4e0eb49c9a2d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 133
            };
        }
    }
}
