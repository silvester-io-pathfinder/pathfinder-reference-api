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
    public class ShieldSconce : Template
    {
        public static readonly Guid ID = Guid.Parse("784f13b8-c6eb-461f-a423-34b56f16204e");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Shield Sconce",
                Hands = "0",
                ItemLevel = "0",
                Price = 10,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("0ee06297-4994-4219-9e6b-fce7d990f21a"), Type = TextBlockType.Text, Text = "This carefully balanced metal bracket can be attached to the front or top of a shield or tower shield (but not a buckler), allowing you to carry a torch without giving up your shield or holding it in your other hand. While carrying a torch in this way, you must attempt a DC 11 flat check every time you use the Shield Block reaction; on a failure, the torch is extinguished." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3736672b-59e1-4653-98b1-0cf05adaeb59"),
                SourceId = PathfinderSocietyGuide.ID,
                Page = 115
            };
        }
    }
}
