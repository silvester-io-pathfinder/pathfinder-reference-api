using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class BuoyancyVest : Template
    {
        public static readonly Guid ID = Guid.Parse("aa28dbfb-0480-494f-afc1-bbe71b70b19b");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Buoyancy Vest",
                Hands = "0",
                Price = 500,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c4d3e330-3877-4a08-8352-9b44a3b7091e"), Type = TextBlockType.Text, Text = "This canvas vest has been filled with cork shavings, tightly folded, and sewn shut. Wearing a buoyancy vest allows you to float in water with a lowered risk of sinking. If you end your turn in water while wearing a buoyancy vest and haven't succeeded at a Swim action that turn, attempt a DC 5 flat check. On a success, you do not sink, though you can still get moved by the current, as determined by the GM. The GM can also determine whether the vest is more or less effective in different weather conditions, raising the DC in rough waters or lowering the DC in calm water." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("44fab1cc-b993-41d5-9b62-153bd40f3fce"),
                SourceId = PathfinderSocietyGuide.ID,
                Page = 114
            };
        }
    }
}
