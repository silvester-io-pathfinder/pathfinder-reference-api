using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Skulk : Template
    {
        public static readonly Guid ID = Guid.Parse("5c5d9ed1-dbcf-48e5-a8f5-0a7c5dd8d838");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Skulk",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("00d4f6bb-e689-4e8d-91e7-80e36c5b2b75"), Type = TextBlockType.Text, Text = "Skulks are a family of humanoids whose skin can shift coloration to aid in stealth." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2dcd4982-57fb-49f9-bc1c-0dce21325404"),
                SourceId = Bestiary2.ID,
                Page = 309
            };
        }
    }
}
