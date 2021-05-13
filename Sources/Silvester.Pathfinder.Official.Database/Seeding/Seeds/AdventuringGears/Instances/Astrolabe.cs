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
    public class Astrolabe : Template
    {
        public static readonly Guid ID = Guid.Parse("fa034d2e-aa2d-4bea-92d8-fde658807406");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Astrolabe",
                Hands = "2",
                ItemLevel = "2",
                Price = 3000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override IEnumerable<AdventuringGearVariant> GetVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("81e94f0b-6555-4c97-a23b-de424a4388ce"),
                NameAddendum = "Mariner's",
                DescriptionAddendum = "A mariner's astrolabe contains additional stabilizers that make it suitable for use on moving surfaces, such as the deck of a ship.",
                Price = 5000,
                ItemLevel = 3,
                Hands = 0,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }
        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ea5b68fe-35b4-4280-aada-20a4780839e1"), Type = TextBlockType.Text, Text = "Astrolabes can be used for navigation in unfamiliar or featureless locations. To use an astrolabe, the holder must be trained in Survival. By spending 1 minute to measure the height of the stars and planets, a holder who knows the time and date can determine the latitude, and a holder who knows their latitude can determine the date and time. An astrolabe also grants a +1 item bonus on checks to identify celestial bodies. A standard astrolabe only functions on steady ground." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b6b57c60-c14c-4a67-8cf1-c8c0e432af7d"),
                SourceId = PathfinderSocietyGuide.ID,
                Page = 34
            };
        }
    }
}
