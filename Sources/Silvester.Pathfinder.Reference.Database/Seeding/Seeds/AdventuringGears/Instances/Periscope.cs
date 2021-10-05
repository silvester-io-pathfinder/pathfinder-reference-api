using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class Periscope : Template
    {
        public static readonly Guid ID = Guid.Parse("a905c052-59af-4d59-8e6b-3dddbe09675a");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Periscope",
                Hands = "2",
                Price = 2500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("13b0edc2-2f01-41b7-b409-812959ca0a25"), Type = TextBlockType.Text, Text = "This is a 2-foot-long tube with two angled mirrors, one at each end. When the mirrors are aligned correctly, you can look around obstacles while remaining behind cover. This doesn't provide a sufficient line of effect to target creatures around corners." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7441bb2d-ec5e-402c-becb-929d7463ca1e"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 249
            };
        }
    }
}
