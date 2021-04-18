using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemCurses.Instances
{
    public class ArrowAttracting : AbstractItemCurseTemplate
    {
        public override ItemCurse GetItemCurse(ItemCurseSeeder seeder)
        {
            return new ItemCurse
            {
                Id = Guid.Parse("247f52a1-f309-4e64-9020-6cec69d2a048"),
                Name = "Arrow Attracting",
                Usage = "curses armor or shield",
                Level = 8
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks(ItemCurseSeeder seeder)
        {
            yield return new TextBlock { Id = Guid.Parse("5fe7530b-0555-4b3e-88a0-6bd6f28e08cc"), Type = TextBlockType.Text, Text = "An item affected by an arrow attracting curse protects you normally, but it draws ranged attacks like a magnet. Whenever a creature within 120 feet misses with a ranged attack, it must immediately reroll the attack against your AC, affecting you depending on the result of the new attack roll. The arrow attraction curse activates only if you could have been a legitimate target. Creatures that intentionally attempt to miss a ranged attack do not activate an arrow attraction curse. Once the curse has activated for the first time, the item fuses to you." };
        }

        public override SourcePage GetSourcePage(ItemCurseSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("33411eb6-96e3-4ef9-a3fc-3371cf073dc9"),
                SourceId = seeder.GetSourceByName("Gamemastery Guide").Id,
                Page = 92
            };
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Rare";
            yield return "Cursed";
            yield return "Magical";
            yield return "Abjuration";
        }
    }
}
