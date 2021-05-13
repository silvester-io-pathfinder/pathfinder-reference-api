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
    public class Spyglass : Template
    {
        public static readonly Guid ID = Guid.Parse("6afd5c23-72ad-48e0-bb63-6dec160c3e73");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Spyglass",
                Hands = "2",
                ItemLevel = "0",
                Price = 2000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<AdventuringGearVariant> GetVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("e75078d5-0865-4a97-aa5c-043de31f462e"),
                NameAddendum = "Fine",
                DescriptionAddendum = "A fine spyglass adds a +1 item bonus to Perception checks to notice details at a distance.",
                ItemLevel = 4,
                Price = 8000,
                Hands = 2,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("08f152c3-8c0e-4c63-a26b-67db03030021"), Type = TextBlockType.Text, Text = "A typical spyglass lets you see eight times farther than normal." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b65a32ec-7241-46a9-ad3a-1e8bce4f75bd"),
                SourceId = CoreRulebook.ID,
                Page = 291
            };
        }
    }
}
