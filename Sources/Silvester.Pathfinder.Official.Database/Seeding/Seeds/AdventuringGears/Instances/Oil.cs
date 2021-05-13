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
    public class Oil : Template
    {
        public static readonly Guid ID = Guid.Parse("cc4d4621-bf02-484a-93ad-9b14f6e93b0b");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Oil",
                Hands = "2",
                ItemLevel = "0",
                Price = 1,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a31be45d-e190-43d7-84a6-5a45416d25a5"), Type = TextBlockType.Text, Text = "You can use oil to fuel lanterns, but you can also set a pint of oil aflame and throw it. You must first spend an Interact action preparing the oil, then throw it with another action as a ranged attack. If you hit, it splatters on the creature or in a single 5-foot square you target. You must succeed at a DC 10 flat check for the oil to ignite successfully when it hits. If the oil ignites, the target takes 1d6 fire damage." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dcfdd5ba-a856-40a3-b30f-445aea929b24"),
                SourceId = CoreRulebook.ID,
                Page = 291
            };
        }
    }
}
