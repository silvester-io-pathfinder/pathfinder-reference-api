using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Magusi
{
    public class ArcaneCascade : Template
    {
        public static readonly Guid ID = Guid.Parse("e67780a0-9969-4b09-b583-37e90b5ec447");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Arcane Cascade", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4a71401b-56f8-47be-a510-689987c71069"), Type = TextBlockType.Text, Text = "After you wield magic, you can enter a special stance to make your attacks more effective." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("86983aeb-b390-47ca-89d7-c575a411dc37"), Feats.Instances.ArcaneCascade.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("56660f50-74a9-460d-b0a0-b3caeb34cfe4"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 38
            };
        }
    }
}
