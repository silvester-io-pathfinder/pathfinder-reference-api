using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Inventors
{
    public class Explode : Template
    {
        public static readonly Guid ID = Guid.Parse("1879d610-f65a-4f17-99fb-e09b26b69a33");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Explode", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("3553ce65-21c7-4174-af3e-f41329bb9db5"), Type = TextBlockType.Text, Text = "Your innovation is a creation barely held together by your own engineering, always on the edge of completely falling apart. Though this adds risk, it also means you can coax it to perform far beyond its design specifications using special unstable actions." };
            yield return new TextBlock { Id = Guid.Parse("0c43f034-f2df-4ead-9982-84ef4e379a2c"), Type = TextBlockType.Text, Text = "While inventors can learn various unstable actions over their career, all at least know how to make their innovation Explode." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("869e1aac-9f14-4e53-9e03-afd299641805"), Feats.Instances.Explode.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b9260dcc-51ab-4802-9eaa-9d3331ce0bc0"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 19
            };
        }
    }
}
