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
    public class Reconfigure : Template
    {
        public static readonly Guid ID = Guid.Parse("6192a15f-e07d-4ed6-8c77-8de36e50c2b8");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 3,
                Name = "Reconfigure", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("be86987e-fdd0-40a6-a58e-8b71b951434e"), Type = TextBlockType.Text, Text = "You've become an expert in all crafts and are always adjusting your inventions. You can attempt to change the modifications on your innovation by spending 1 day of downtime tinkering with it and attempting a Crafting check, with a high DC for your level. On a success, you can change one modification you've chosen for your innovation to a different modification of the same kind (initial, breakthrough, or revolutionary)." };
            yield return new TextBlock { Id = Guid.Parse("462c04d3-7233-4dd0-866e-880f44133a08"), Type = TextBlockType.Text, Text = "If you have any modification feats, on a successful check you can choose to instead retrain a modification feat to a different modification feat. The new feat has to meet the standard restrictions for retraining." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7ab4ba9a-2ae5-48bc-932f-ba851cee7216"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 20
            };
        }
    }
}
