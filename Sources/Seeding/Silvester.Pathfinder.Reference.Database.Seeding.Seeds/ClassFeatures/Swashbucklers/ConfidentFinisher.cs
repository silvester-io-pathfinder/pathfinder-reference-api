using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Swashbucklers
{
    public class ConfidentFinisher : Template
    {
        public static readonly Guid ID = Guid.Parse("77db9f58-cc4e-43dc-bb50-cafb38ded3df");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Confident Finisher", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("54c6ef78-3a4f-4309-9e06-47119f9c2cee"), Type = TextBlockType.Text, Text = "You gain an elegant finishing attack you can make when you have panache. You gain the Confident Finisher action." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("8b149731-2550-44e9-bf4e-44ebc296fd6d"), Feats.Instances.ConfidentFinisher.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("50b04d32-90a9-45a5-905c-7b0f221e9917"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 85
            };
        }
    }
}
