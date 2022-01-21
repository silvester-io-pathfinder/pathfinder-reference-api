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
    public class VivaciousSpeed : Template
    {
        public static readonly Guid ID = Guid.Parse("7e21ab91-232a-4cd2-9639-cea3091a8491");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 3,
                Name = "Vivacious Speed", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8017ba59-749f-4c41-9f8e-a6287604a68e"), Type = TextBlockType.Text, Text = "When you've made an impression, you move even faster than normal, darting about the battlefield with incredible speed. Increase the status bonus to your Speeds when you have panache to a +10-foot status bonus; this bonus increases by 5 feet at 7th, 11th, 15th, and 19th levels. When you don't have panache, you still get half this status bonus to your Speed, rounded down to the nearest 5-foot increment." };

        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("149ea594-a316-4f99-bd38-8baec8bc39d3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 84
            };
        }
    }
}
