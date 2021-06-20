using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class WaterproofJournal : Template
    {
        public static readonly Guid ID = Guid.Parse("008da8ab-fa02-4ad0-9ba2-40dca2c5e0be");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Waterproof Journal",
                Hands = "0",
                Price = 500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("95c90f90-5864-4c66-bb03-94a7200c29f5"), Type = TextBlockType.Text, Text = "This leather-bound tome is specially treated to protect from water damage and comes with a key and a treated slipcase that bears a simple lock to keep the tome secure. This journal is commonly used by adventuring scholars and ship navigators for recording their journeys." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c79be0a7-c09d-4a03-9bbe-94e6e7a94ed1"),
                SourceId = PathfinderSocietyGuide.ID,
                Page = 30
            };
        }
    }
}
