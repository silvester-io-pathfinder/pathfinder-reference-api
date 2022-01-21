using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Monks
{
    public class MetalStrikes : Template
    {
        public static readonly Guid ID = Guid.Parse("aa1e8983-6e82-4b6a-8d8b-a2deef617c1a");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 9,
                Name = "Metal Strikes", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8717cd5d-5f37-4f33-ab62-ed013bd8878b"), Type = TextBlockType.Text, Text = "You can adjust your body to make unarmed attacks infused with the mystic energy of rare metals. Your unarmed attacks are treated as cold iron and silver. This allows you to deal more damage to a variety of supernatural creatures, such as demons, devils, and fey." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6c85cb96-7ccb-4801-9722-f349b33ad06e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 157
            };
        }
    }
}
