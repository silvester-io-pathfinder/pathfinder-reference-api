using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class Rope : Template
    {
        public static readonly Guid ID = Guid.Parse("6e9cb8a6-3ecb-49c2-b660-e6d9bc70709a");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Rope",
                Hands = "2",
                Price = 50,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("fb65e32e-5654-4edc-8d8d-15afd05e9378"), Type = TextBlockType.Text, Text = "A rope is a group of yarns, plies, fibers or strands that are twisted or braided together into a larger and stronger form. Ropes have tensile strength and so can be used for dragging and lifting." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8c1fc540-c33c-4e58-b476-af7ad39de628"),
                SourceId = CoreRulebook.ID,
                Page = 288
            };
        }
    }
}
