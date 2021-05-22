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
    public class MaterialComponentPouch : Template
    {
        public static readonly Guid ID = Guid.Parse("f0ee4a34-407e-410b-bae1-e84dfe9bef81");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Material Component Pouch",
                Hands = "1",
                ItemLevel = "0",
                Price = 50,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4258e9e5-c57e-437c-8591-41ccc400e9b1"), Type = TextBlockType.Text, Text = "This pouch contains material components for those spells that require them. Though the components are used up over time, you can refill spent components during your daily preparations." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c7235d4c-5b48-42b5-b353-8c55539c78d4"),
                SourceId = CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
