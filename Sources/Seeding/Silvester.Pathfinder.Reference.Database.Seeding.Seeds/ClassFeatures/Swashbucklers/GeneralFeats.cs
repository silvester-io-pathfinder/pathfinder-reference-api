using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Swashbucklers
{
    public class GeneralFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("d01ca359-56d5-440d-a3ee-2bb029956638");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 3,
                Name = "General Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("93c93e69-6e59-4305-afcb-834026c76abb"), Type = TextBlockType.Text, Text = "At 3rd level and every 4 levels thereafter, you gain a general feat. General feats are listed in Chapter 5." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyGeneralFeat(Guid.Parse("ea18a262-2fc4-420f-8d03-307b97e2348a"), Guid.Parse("62748269-c8f6-453c-9dc8-eddd651cca49"), requiredLevel: 3);
            builder.GainAnyGeneralFeat(Guid.Parse("2478b397-4a83-4db1-aee4-4ec430e8da95"), Guid.Parse("b194d72f-1545-44e1-b377-50ceef530202"), requiredLevel: 7);
            builder.GainAnyGeneralFeat(Guid.Parse("ebefb5b9-5126-4098-8dcf-3502e390bb00"), Guid.Parse("a6d6e38f-3f65-49dc-9100-f14b37be6d41"), requiredLevel: 11);
            builder.GainAnyGeneralFeat(Guid.Parse("3d63c2d3-0dbc-44cf-862c-164529fd293a"), Guid.Parse("6c8b0ca8-ceea-4984-94c4-8b0c3630ff05"), requiredLevel: 15);
            builder.GainAnyGeneralFeat(Guid.Parse("f082c7f9-ce65-480e-ab0f-2483b26323b6"), Guid.Parse("8b2cc291-90a5-4bd4-bd7d-b2f5000240b7"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("10029988-ea86-4ad7-8fab-981e85d4b101"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 85
            };
        }
    }
}
