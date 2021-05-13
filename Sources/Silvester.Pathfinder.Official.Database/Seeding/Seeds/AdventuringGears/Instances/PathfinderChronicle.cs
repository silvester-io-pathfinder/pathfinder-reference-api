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
    public class PathfinderChronicle : Template
    {
        public static readonly Guid ID = Guid.Parse("0f20c6ab-6c7a-4f5c-9237-d83ed9bd3f19");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Pathfinder Chronicle",
                Hands = "1",
                ItemLevel = "3",
                Price = 600,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1b9cbcf2-db94-447d-9633-d74ee300ce47"), Type = TextBlockType.Text, Text = "This item is uncommon, but characters who are members of the Pathfinder Society have access to it." };
            yield return new TextBlock { Id = Guid.Parse("dd0c0f1c-cabe-41be-bed7-1ea9368d0150"), Type = TextBlockType.Text, Text = "Numerous volumes and editions of the Pathfinder Chronicles exist, each cataloging different adventures. Pathfinder Chronicles are a type of scholarly journal that specifically devotes topics to Pathfinder discoveries, rather than more theoretical academic topics. Because Pathfinders have better access to these chronicles than other scholarly journals, they are particularly common among Pathfinder agents building a library of reference texts." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a56cbac4-f3e2-4329-ba5f-ff0bd483d7f4"),
                SourceId = CharacterGuide.ID,
                Page = 110
            };
        }
    }
}
