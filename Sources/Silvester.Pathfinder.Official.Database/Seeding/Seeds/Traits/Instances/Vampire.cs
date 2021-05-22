using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Vampire : Template
    {
        public static readonly Guid ID = Guid.Parse("43d91dda-c051-4a9d-abc0-ad4fd42667b2");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Vampire",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4d033f68-28ff-453a-a268-417c949ad133"), Type = TextBlockType.Text, Text = "Undead creatures who thirst for blood, vampires are notoriously versatile and hard to destroy." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d5593f5-e31c-461d-9b88-df5b967de6ea"),
                SourceId = Bestiary.ID,
                Page = 347
            };
        }
    }
}
