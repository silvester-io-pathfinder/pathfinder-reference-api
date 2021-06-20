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
    public class DetectivesKit : Template
    {
        public static readonly Guid ID = Guid.Parse("e4eeffb1-68b5-4846-be37-62118863014e");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Detective's Kit",
                Hands = "2",
                Price = 2500,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ccb1bc2d-5cf3-495b-b677-19dcfc8b54d8"), Type = TextBlockType.Text, Text = "This leather satchel contains empty vials, a pair of tweezers, a supply of small linen cloths, a set of brass calipers and a knotted string for measuring distances, several pieces of chalk, a pen, and a blank notebook for keeping notes. Every component of a detective's kit is of exceeding quality, and thus a detective's kit adds a +1 item bonus to checks to investigate a crime scene, a clue, or similar details." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c60b4087-35ad-400b-b704-825fce18f256"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 249
            };
        }
    }
}
