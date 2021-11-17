using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Bards
{
    public class Muses : Template
    {
        public static readonly Guid ID = Guid.Parse("e02ec0b4-d467-4c73-a04a-5419704d3da9");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Muses", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4eb6ac07-a3fa-4a86-a6be-d4f9f9bdc75c"), Type = TextBlockType.Text, Text = "As a bard, you select one muse at 1st level. This muse leads you to great things, and might be a physical creature, a deity, a philosophy, or a captivating mystery." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyMuse(Guid.Parse("2bbf93d6-7697-4e31-9b58-09fa7339306f"));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e03fe73f-db5a-4efa-89c1-dd7714a27192"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 97
            };
        }
    }
}
