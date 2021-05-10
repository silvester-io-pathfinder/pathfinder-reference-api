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
    public class AdventurersPack : AbstractAdventuringGearTemplate
    {
        public static readonly Guid ID = Guid.Parse("97f361db-58be-487f-a5aa-ced5e1a2197f");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Adventurer's Pack",
                Hands = "0",
                ItemLevel = "0",
                Price = 150,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("da790c29-3bb6-4262-a3e8-bc4058fc18bc"), Type = TextBlockType.Text, Text = "This item is the starter kit for an adventurer, containing the essential items for exploration and survival. The Bulk value is for the entire pack together, but see the descriptions of individual items as necessary." };
            yield return new TextBlock { Id = Guid.Parse("01d7deb6-06a4-4e24-88bb-145bf823125b"), Type = TextBlockType.Text, Text = "The pack contains the following items: backpack (containing the other goods), bedroll, 10 pieces of chalk, flint and steel, 50 feet of rope, 2 weeks' rations, soap, 5 torches, and a waterskin." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0aa4ba0e-3c12-4d52-9156-fdbe8562dcb4"),
                SourceId = CoreRulebook.ID,
                Page = 289
            };
        }
    }
}
