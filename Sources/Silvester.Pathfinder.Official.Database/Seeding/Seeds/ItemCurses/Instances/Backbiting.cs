using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemCurses.Instances
{
    public class Backbiting : AbstractItemCurseTemplate
    {
        public override ItemCurse GetItemCurse(ItemCurseSeeder seeder)
        {
            return new ItemCurse
            {
                Id = Guid.Parse("11d686ec-2c9a-4c0f-b7da-d8318c38bc64"),
                Name = "Backbiting",
                Usage = "curses a weapon",
                Level = 4
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks(ItemCurseSeeder seeder)
        {
            yield return new TextBlock { Id = Guid.Parse("0a648746-7fea-4db6-a7e9-14adb15467ec"), Type = TextBlockType.Text, Text = "A weapon with the backbiting curse warps space in response to catastrophic mishaps. Whenever you critically fail at a Strike with this weapon, the weapon curls around (or its projectile swerves through the air) to strike you in the back as though you hit yourself, automatically dealing maximum damage to you." };
        }

        public override SourcePage GetSourcePage(ItemCurseSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("179f1b27-8e26-4a51-a396-a01a1b2d6f6a"),
                SourceId = seeder.GetSourceByName("Gamemastery Guide").Id,
                Page = 92
            };
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Rare";
            yield return "Cursed";
            yield return "Magical";
            yield return "Evocation";
        }
    }
}
