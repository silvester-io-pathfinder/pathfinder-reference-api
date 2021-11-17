using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rangers
{
    public class AncestryFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("c8e3b7a3-ba2a-4ab8-874d-e6e7764938bf");

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
            yield return new TextBlock { Id = Guid.Parse("c4e17005-6249-4352-b755-154ae90d3a30"), Type = TextBlockType.Text, Text = "In addition to the ancestry feat you started with, you gain an ancestry feat at 5th level and every 4 levels thereafter." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAncestryFeat(Guid.Parse("95d63a64-36dc-4011-b3bc-dd897c79b879"), Guid.Parse("f36861ea-4099-419f-b520-5ecbd895bb12"), requiredLevel: 5);
            builder.GainAnyAncestryFeat(Guid.Parse("92e18ac1-0721-461c-a28c-96cfa7d17c2f"), Guid.Parse("aadd6a89-c254-4fbb-9a06-59466a8cccaa"), requiredLevel: 9);
            builder.GainAnyAncestryFeat(Guid.Parse("7e283b3e-74a1-49d2-aa62-5cdfc18e0dd1"), Guid.Parse("0e1c9200-5eee-469a-a245-7479149c635e"), requiredLevel: 13);
            builder.GainAnyAncestryFeat(Guid.Parse("e56daac3-9543-4269-9946-fd8ca79c4d83"), Guid.Parse("a229c28f-01a2-4083-8338-2060fdbf87ff"), requiredLevel: 17);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fb703e3c-1860-4831-8179-bdc36de7e516"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 169
            };
        }
    }
}
