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
    public class Caltrops : Template
    {
        public static readonly Guid ID = Guid.Parse("e6026e0d-1fe6-42c1-964b-767e0748b927");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Caltrops",
                Hands = "1",
                ItemLevel = "0",
                Price = 30,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("772aa19a-25d2-438a-a551-ad4f5c0091f6"), Type = TextBlockType.Text, Text = "These four-pronged metal spikes can cause damage to a creature's feet. You can scatter caltrops in an empty square adjacent to you with an Interact action. The first creature that moves into that square must succeed at a DC 14 Acrobatics check or take 1d4 piercing damage and 1 persistent bleed damage. A creature taking persistent bleed damage from caltrops takes a –5-foot penalty to its Speed. Spending an Interact action to pluck the caltrops free reduces the DC to stop the bleeding. Once a creature takes damage from caltrops, enough caltrops are ruined that other creatures moving into the square are safe. Deployed caltrops can be salvaged and reused if no creatures took damage from them.Otherwise, enough caltrops are ruined that they can't be salvaged." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6cac8caf-e1a7-4a50-8813-77896127dd64"),
                SourceId = CoreRulebook.ID,
                Page = 289
            };
        }
    }
}
