using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Capacity : Template
    {
        public static readonly Guid ID = Guid.Parse("bdc0e924-839e-4542-98d9-b4bc47baafbc");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Capacity",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f82cb984-4e32-4636-a9bf-3d37e36ef8c1"), Type = TextBlockType.Text, Text = "Weapons that have the capacity trait typically have multiple barrels or chambers capable of containing a round of ammunition. Capacity is always accompanied by a number indicating the number of barrels or chambers. After a capacity weapon is fired, you can select the next loaded barrel or chamber as an Interact action that doesn't require a free hand. Each barrel or chamber can be reloaded after it's fired as a separate Interact action." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9097328f-24df-42fa-9ac7-280ca213746b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 151
            };
        }
    }
}
