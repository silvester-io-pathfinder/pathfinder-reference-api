using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Conjuration : Template
    {
        public static readonly Guid ID = Guid.Parse("556b46f3-1953-4bd8-9ae2-ad4718ff829e");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Conjuration",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2893131c-1352-4078-a76f-aa2cb29c7dcd"), Type = TextBlockType.Text, Text = "Effects and magic items with this trait are associated with the conjuration school of magic, typically involving summoning, creation, teleportation, or moving things from place to place." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("708acc8e-30a0-4c44-a17d-fceab7d750ac"),
                SourceId = CoreRulebook.ID,
                Page = 630
            };
        }
    }
}
