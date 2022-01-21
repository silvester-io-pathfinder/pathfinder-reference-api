using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class AirBladder : Template
    {
        public static readonly Guid ID = Guid.Parse("3ac89cb4-2430-46cc-b717-b7785a64abc2");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Air Bladder",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("28e46063-bb0b-4e1b-9391-a0ad7693cd72"), "This weighted animal bladder can be inflated with air in preparation for a dive. It holds enough air to breathe for one round. As a free action, you can inhale the contents of the air bladder, which resets the number of rounds you can hold your breath (see the rules for drowning and suffocating). You can inflate the bladder or remove its attached weight as an Interact action. An unattached inflated bladder without the weight will float toward the surface of the water at a rate of 60 feet per round.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("789767d6-f9f9-463b-a9a4-15612e56cb22"),
                Name = "Air Bladder",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 0,
                Price = 10,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("93fd76ba-4eab-464b-9d70-285970dfa0c1"),
                Name = "Air Bladder (Inflated)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 0,
                Price = 10,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("81818f4f-e441-4c7d-9695-b09ff79085df"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 92
            };
        }
    }
}
