using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Investigators
{
    public class DeviseAStratagem : Template
    {
        public static readonly Guid ID = Guid.Parse("66c8dcdc-b2a4-4475-8578-3a713460dbbc");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Devise a Stratagem", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1a0eb7d3-bf9b-4ed9-8f9f-5f1622d42c11"), Type = TextBlockType.Text, Text = "You can play out a battle in your head, using brains rather than brawn to execute an attack." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("c6e94293-580f-4dd2-b937-2437545a9c94"), Feats.Instances.DeviseAStratagem.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d322306e-3283-4386-a1ae-4644e68dd4b7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 56
            };
        }
    }
}
