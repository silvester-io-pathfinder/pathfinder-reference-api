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
    public class Cookware : AbstractAdventuringGearTemplate
    {
        public static readonly Guid ID = Guid.Parse("e52c7a7c-7032-4cbf-8200-662ccaf96062");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Cookware",
                Hands = "2",
                ItemLevel = "0",
                Price = 100,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("5a30e3c9-b0ed-4904-8b32-91fba52708b5"), Type = TextBlockType.Text, Text = "While the rulebooks do not explicitly mention the contents of 'cookware', it seems to be generally accepted that it contains generic items such as some pots and pans, plates, cutlery, a kettle, and perhaps a wooden board." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("abb4d62b-0f95-4ef7-8e1d-dde096062622"),
                SourceId = CoreRulebook.ID,
                Page = 288
            };
        }
    }
}
