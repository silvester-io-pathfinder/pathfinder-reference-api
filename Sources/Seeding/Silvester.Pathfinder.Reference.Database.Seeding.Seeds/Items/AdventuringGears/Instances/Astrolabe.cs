using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
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
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("ea5b68fe-35b4-4280-aada-20a4780839e1"), "Astrolabes can be used for navigation in unfamiliar or featureless locations. To use an astrolabe, the holder must be trained in Survival. By spending 1 minute to measure the height of the stars and planets, a holder who knows the time and date can determine the latitude, and a holder who knows their latitude can determine the date and time. An astrolabe also grants a +1 item bonus on checks to identify celestial bodies. A standard astrolabe only functions on steady ground.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("cb0dd2c0-0640-4995-b2d9-9e03cf6d4761"),
                Name = "Astrolabe (Standard)",
                Usage = "Held in 2 hands.",
                Level = 2,
                Hands = "2", 
                Price = 3000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("81e94f0b-6555-4c97-a23b-de424a4388ce"),
                Name = "Astrolabe (Mariner's)",
                Usage = "Held in 2 hands.",
                Level = 3,
                Hands = "2", 
                Price = 5000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                   .Text(Guid.Parse("546f8ed1-2816-45e3-a61d-7831460f0f42"), "A mariner's astrolabe contains additional stabilizers that make it suitable for use on moving surfaces, such as the deck of a ship.")
                   .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b6b57c60-c14c-4a67-8cf1-c8c0e432af7d"),
                SourceId = Sources.Instances.PathfinderSocietyGuide.ID,
                Page = 34
            };
        }
    }
}
