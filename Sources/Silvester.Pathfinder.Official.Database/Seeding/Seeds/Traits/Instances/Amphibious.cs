using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Amphibious : Template
    {
        public static readonly Guid ID = Guid.Parse("5da3fe9a-3652-44f9-9e57-64534fb1ac2d");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Amphibious",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4318941d-c9ed-4e02-be9b-f24bbe94e091"), Type = TextBlockType.Text, Text = "An amphibious creature can breathe in water and in air, even outside of its preferred environment, usually indefinitely but at least for hours. These creatures often have a swim Speed. Their bludgeoning and slashing unarmed Strikes don't take the usual –2 penalty for being underwater." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eee01ce1-5d98-4e3d-a3db-aeaefb5a0939"),
                SourceId = Bestiary.ID,
                Page = 345
            };
        }
    }
}
