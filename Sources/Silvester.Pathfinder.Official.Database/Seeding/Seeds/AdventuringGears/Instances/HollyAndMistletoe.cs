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
    public class HollyAndMistletoe : Template
    {
        public static readonly Guid ID = Guid.Parse("ba1e620a-1e7f-49c8-904d-52ed144470f8");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Holly and Mistletoe",
                Hands = "1",
                Price = 0,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7b3f776e-63f5-412d-83c0-33b11f2c35c6"), Type = TextBlockType.Text, Text = "Plants of supernatural significance provide a primal focus for primal spellcasters, such as druids, when using certain abilities and casting some spells. A bundle of holly and mistletoe must be held in one hand to use it. Other primal foci exist for druids focused on other aspects of nature." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("48037943-1577-48cb-827e-bce1ab507149"),
                SourceId = CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
