using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemCurses.Instances
{
    public class Dependent : AbstractItemCurseTemplate
    {
        public override ItemCurse GetItemCurse(ItemCurseSeeder seeder)
        {
            return new ItemCurse
            {
                Id = Guid.Parse("6e4d1c6a-b506-4a2f-8ab0-03a1ebea1696"),
                Name = "Dependent",
                Usage = "curses gear used for skills or a weapon",
                Level = 9
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks(ItemCurseSeeder seeder)
        {
            yield return new TextBlock { Id = Guid.Parse("d2124045-cd88-43c5-985d-f62755d34242"), Type = TextBlockType.Text, Text = "The dependent curse makes an item function properly only under certain circumstances. Whenever you use the item to perform a skill check or use the weapon in combat, your degree of success is one worse than the result you rolled unless those specific conditions are met. The most common types of dependent curses are nocturnal or diurnal—functioning normally only at night or only during the day, respectively—but more restrictive curses do exist, such as a curse that restricts the item’s use to underground or a curse that allows the item to function effectively only during autumn." };
        }

        public override SourcePage GetSourcePage(ItemCurseSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("9d6def2c-671e-41c5-9422-3fd2f06fd5aa"),
                SourceId = seeder.GetSourceByName("Gamemastery Guide").Id,
                Page = 93
            };
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Rare";
            yield return "Cursed";
            yield return "Magical";
            yield return "Transmutation";
        }
    }
}
