using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class DuelingCape : Template
    {
        public static readonly Guid ID = Guid.Parse("e2e6da71-2f98-46c2-80eb-adb3ba10fcaa");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Dueling Cape",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("767ec192-efd1-4f95-b869-5754be5142b4"), "You can pull a dueling cape you're wearing from your shoulder and wrap it around your arm with an Interact action. While wielding the dueling cape this way, the cape uses that arm and hand, and you can't hold anything else in that hand. While you do so, you can spend an action to hold it in a protective position, giving you a +1 circumstance bonus to AC and to Deception checks to Feint until the start of your next turn.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("0b1b9e77-4abc-4611-ac2d-8dddb9bf3450"),
                Name = "Dueling Cape",
                Level = 0,
                Hands = "1",
                Price = 50,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e8459024-60cd-46ec-b64d-7b1b1adb308f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 249
            };
        }
    }
}
