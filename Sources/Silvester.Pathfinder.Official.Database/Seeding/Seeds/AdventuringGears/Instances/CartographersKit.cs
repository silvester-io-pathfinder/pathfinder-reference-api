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
    public class CartographersKit : Template
    {
        public static readonly Guid ID = Guid.Parse("9eaa4740-ca64-457f-b20e-94cbada90b59");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Cartographer's Kit",
                Hands = "0",
                ItemLevel = "3",
                Price = 4200,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ed20f43a-e3cf-4c2b-a5c0-47993f534e0f"), Type = TextBlockType.Text, Text = "Players can gain access to faction-specific gear by taking the corresponding Faction Gear Access Game Reward, available when they reach 20 reputation with the respective faction." };
            yield return new TextBlock { Id = Guid.Parse("7630b480-2289-4c24-ae0f-ffcb8bb3d30e"), Type = TextBlockType.Text, Text = "This kit includes a writing set, a compass, a standard astrolabe, a ruler, and a survey map." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7028a268-35b0-47e5-92a2-1f1353e66e56"),
                SourceId = PathfinderSocietyGuide.ID,
                Page = 34
            };
        }
    }
}
