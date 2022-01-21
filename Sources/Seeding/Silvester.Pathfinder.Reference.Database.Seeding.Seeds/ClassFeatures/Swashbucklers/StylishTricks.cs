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
    public class StylishTricks : Template
    {
        public static readonly Guid ID = Guid.Parse("015f0d6f-2f37-4e3b-ba81-daffec8edf70");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 3,
                Name = "Stylish Tricks", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c2d7ee99-2c99-4326-b5be-9ac149b8199d"), Type = TextBlockType.Text, Text = "At 3rd level, 7th level, and 15th level, you gain a skill feat. This feat must be for Acrobatics or the trained skill from your swashbuckler's style." };

        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5afeb149-e874-437a-91bc-ea2051d69d57"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 84
            };
        }
    }
}
