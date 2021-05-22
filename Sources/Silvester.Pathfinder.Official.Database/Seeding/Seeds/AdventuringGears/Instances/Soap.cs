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
    public class Soap : Template
    {
        public static readonly Guid ID = Guid.Parse("bc8f44fc-727d-4528-a277-bcc88c5f6028");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Soap",
                Hands = "1",
                ItemLevel = "0",
                Price = 2,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("5c282672-4682-48a9-acbc-390174e39d36"), Type = TextBlockType.Text, Text = "Soap is a salt of a fatty acid used in a variety of cleansing and lubricating products. In a domestic setting, soaps are surfactants usually used for washing, bathing, and other types of housekeeping. In industrial settings, soaps are used as thickeners, components of some lubricants, and precursors to catalysts." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ca8e6b9e-ef46-4629-ae1f-76d13afe203b"),
                SourceId = CoreRulebook.ID,
                Page = 288
            };
        }
    }
}
