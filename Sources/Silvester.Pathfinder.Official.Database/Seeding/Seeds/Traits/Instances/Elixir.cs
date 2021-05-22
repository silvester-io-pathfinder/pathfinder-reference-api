using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Elixir : Template
    {
        public static readonly Guid ID = Guid.Parse("53ba888b-4e97-4478-8617-7ed9c6654994");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Elixir",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("22d38176-5c10-4c80-b4aa-f31825d543b9"), Type = TextBlockType.Text, Text = "Elixirs are alchemical liquids that are used by drinking them." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1e9e8df9-a6ff-4e1d-ab10-ff2a9f339ead"),
                SourceId = CoreRulebook.ID,
                Page = 631
            };
        }
    }
}
