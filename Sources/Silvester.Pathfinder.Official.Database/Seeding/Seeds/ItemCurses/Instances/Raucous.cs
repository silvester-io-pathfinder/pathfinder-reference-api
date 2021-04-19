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
    public class Raucous : AbstractItemCurseTemplate
    {
        public override ItemCurse GetItemCurse(ItemCurseSeeder seeder)
        {
            return new ItemCurse
            {
                Id = Guid.Parse("dade2400-c464-4171-a0f4-5367292b51a3"),
                Name = "Raucous",
                Usage = "curses gear or a weapon",
                Level = 3
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks(ItemCurseSeeder seeder)
        {
            yield return new TextBlock { Id = Guid.Parse("8aeba1cd-97c8-4c5d-92f9-6a48781efa95"), Type = TextBlockType.Text, Text = "A weapon with the backbiting curse warps space in response to catastrophic mishaps. Whenever you critically fail at a Strike with this weapon, the weapon curls around (or its projectile swerves through the air) to strike you in the back as though you hit yourself, automatically dealing maximum damage to you." };
        }

        public override SourcePage GetSourcePage(ItemCurseSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("9283dbff-bc55-44ee-bf3c-8b2ac4f873cd"),
                SourceId = GamemasteryGuide.ID,
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
