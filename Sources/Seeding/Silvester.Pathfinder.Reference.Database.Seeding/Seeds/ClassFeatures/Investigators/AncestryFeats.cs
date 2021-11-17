using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Investigators
{
    public class AncestryFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("d53e77b2-607d-4f48-aebf-cc7ff0d9534e");

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
            yield return new TextBlock { Id = Guid.Parse("b3517d5b-d109-4b79-aba9-cd6cedf15a34"), Type = TextBlockType.Text, Text = "In addition to the ancestry feat you started with, you gain an ancestry feat at 5th level and every 4 levels thereafter." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAncestryFeat(Guid.Parse("0642fc08-2029-43cf-ae18-b3081f3444ee"), Guid.Parse("df566d53-7ab6-4f81-9930-f9458d67a782"), requiredLevel: 5);
            builder.GainAnyAncestryFeat(Guid.Parse("dc5d40e9-5ddd-4e25-82a0-85e00e916d64"), Guid.Parse("9dccc751-b90b-4fff-8509-4742bd32fddd"), requiredLevel: 9);
            builder.GainAnyAncestryFeat(Guid.Parse("bda41e89-7012-4848-94f3-506c797fcf27"), Guid.Parse("985c7644-2d9f-47e1-ad05-4b3e21191950"), requiredLevel: 13);
            builder.GainAnyAncestryFeat(Guid.Parse("3065bd9f-2d15-4758-af51-60701df0f98e"), Guid.Parse("501fbc44-f56a-4a4e-b6e2-f3a377f43bf5"), requiredLevel: 17);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6d05f878-85ac-40ba-bf4c-8a94b8d375ea"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 59
            };
        }
    }
}
