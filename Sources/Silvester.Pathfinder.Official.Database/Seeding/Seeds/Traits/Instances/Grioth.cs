using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Grioth : Template
    {
        public static readonly Guid ID = Guid.Parse("f8ca8efb-6017-43d2-9d04-6d70d1c3018f");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Grioth",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7d8277a6-a3bd-4c1c-a52f-e245a491f6d5"), Type = TextBlockType.Text, Text = "A grioth is a batlike alien that wields occult powers and can exist in the dark vacuum of space. They have darkvision and echolocation." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("03903f00-6523-448c-a694-95d0948c0aeb"),
                SourceId = Bestiary3.ID,
                Page = 309
            };
        }
    }
}
