using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rogues
{
    public class AncestryFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("9ac634dc-0a2c-4f98-abe1-78d746643be6");

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
            yield return new TextBlock { Id = Guid.Parse("f944e643-4043-403f-97cb-4340aab5d54f"), Type = TextBlockType.Text, Text = "In addition to the ancestry feat you started with, you gain an ancestry feat at 5th level and every 4 levels thereafter." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAncestryFeat(Guid.Parse("735d0829-5e59-43fc-a782-223939ed2361"), Guid.Parse("aa43f91c-f669-4c7f-b0a8-4a3ef7a5a064"), requiredLevel: 5);
            builder.GainAnyAncestryFeat(Guid.Parse("810f42c5-ac56-45f2-8f8b-5e5f42fb3db4"), Guid.Parse("b9da900a-dd41-4a83-9169-76518ddd0fca"), requiredLevel: 9);
            builder.GainAnyAncestryFeat(Guid.Parse("d4e20b5a-1c8a-4e08-9cbb-fa6ffd8f50fc"), Guid.Parse("b229f45c-7c50-44e8-91d2-46e45311e0b9"), requiredLevel: 13);
            builder.GainAnyAncestryFeat(Guid.Parse("c362442e-fb0a-4dcf-b67e-570456bf3cfd"), Guid.Parse("715c2f2a-e6e9-4fc5-90bc-58fd7c757022"), requiredLevel: 17);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0f6878c6-3c14-46fd-83cc-5f36977fe2fe"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 182
            };
        }
    }
}
