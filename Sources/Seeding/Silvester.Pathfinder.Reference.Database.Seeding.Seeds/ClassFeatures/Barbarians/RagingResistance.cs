using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Barbarians
{
    public class RagingResistance : Template
    {
        public static readonly Guid ID = Guid.Parse("ee011372-f6d7-43a9-bd0c-16b21d631a92");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 9,
                Name = "Raging Resistance", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("e1c34858-c3e9-4ba8-8c7a-bb33f9a6ba36"), Type = TextBlockType.Text, Text = "Repeated exposure and toughened skin allow you to fend off harm. While raging, you gain resistance equal to 3 + your Constitution modifier to damage types based on your instinct." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9ed8c126-4845-4b18-8132-07d18dda1c0f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 85
            };
        }
    }
}
