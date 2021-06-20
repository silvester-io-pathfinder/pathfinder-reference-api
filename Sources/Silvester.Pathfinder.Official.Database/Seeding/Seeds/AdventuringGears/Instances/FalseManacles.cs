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
    public class FalseManacles : Template
    {
        public static readonly Guid ID = Guid.Parse("2f83877d-1461-4ea7-b630-72ab935a19de");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "False Manacles",
                Hands = "2",
                Price = 1000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a267c15c-7486-4a13-af92-fc6e9d034e7b"), Type = TextBlockType.Text, Text = "These manacles are nearly indistinguishable from real manacles upon inspection, but contain a hidden release that enables a wearer who knows the location of the release to free themselves with a single Interact action. An observer who examines the manacles and succeeds at a DC 20 Perception check notices their false nature. On a critical success, the observer finds the location of the hidden catch as well." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b43cebe4-9433-4a80-94d1-1003b52e41c3"),
                SourceId = PathfinderSocietyGuide.ID,
                Page = 114
            };
        }
    }
}
