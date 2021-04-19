using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemCurses.Instances
{
    public class Withering : AbstractItemCurseTemplate
    {
        public override ItemCurse GetItemCurse(ItemCurseSeeder seeder)
        {
            return new ItemCurse
            {
                Id = Guid.Parse("9d831fff-4d11-444f-b90d-0d3b3d393703"),
                Name = "Withering",
                Usage = "curses a ring, staff, or wand",
                Level = 13
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks(ItemCurseSeeder seeder)
        {
            yield return new TextBlock { Id = Guid.Parse("654b78d5-5f42-44fa-930a-25120edfb0d4"), Type = TextBlockType.Text, Text = "A withering curse shrivels vulnerable flesh. Whenever you activate the item, one of your fingers turns black and falls off. You take a –1 status penalty to Thievery checks and Dexterity-based attack rolls with a hand missing two or three fingers; if you lose more than four fingers on one hand, you can’t use that hand to hold objects or use manipulate actions. These fingers can be replaced by magic but are otherwise gone forever. The GM has the final say on how creatures with unusual appendages or numbers of fingers are affected by this curse." };
        }

        public override SourcePage GetSourcePage(ItemCurseSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("7e2873bd-49f8-4ea4-a3df-d4b7b71b7186"),
                SourceId = GamemasteryGuide.ID,
                Page = 93
            };
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Rare";
            yield return "Cursed";
            yield return "Magical";
            yield return "Necromancy";
        }
    }
}
