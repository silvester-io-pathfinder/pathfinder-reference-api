using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class CompassLensatic : Template
    {
        public static readonly Guid ID = Guid.Parse("63c40f21-1e8c-4273-9bec-79fdbaaaa225");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Compass (Lensatic)",
                Hands = "1",
                Price = 2000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("31ada62d-9058-48e4-bdb6-a90ed71e3026"), Type = TextBlockType.Text, Text = "A lensatic compass gives you a + 1 item bonus to these checks." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c7ad2d60-0c88-454e-adbd-0bb169961fab"),
                SourceId = CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
