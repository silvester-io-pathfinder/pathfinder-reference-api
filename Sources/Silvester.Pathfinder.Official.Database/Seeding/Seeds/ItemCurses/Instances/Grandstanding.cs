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
    public class Grandstanding : AbstractItemCurseTemplate
    {
        public override ItemCurse GetItemCurse(ItemCurseSeeder seeder)
        {
            return new ItemCurse
            {
                Id = Guid.Parse("578a1f3e-8039-4342-a2b1-bcfa67035d7a"),
                Name = "Grandstanding",
                Usage = "curses a weapon",
                Level = 11
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks(ItemCurseSeeder seeder)
        {
            yield return new TextBlock { Id = Guid.Parse("bbc4deb5-bd7e-4dce-aa0d-90d32db6da92"), Type = TextBlockType.Text, Text = "Weapons with the grandstanding curse inspire overconfidence in their wielders, demanding style over pragmatism. Whenever you reduce a foe to 0 Hit Points, you lose all remaining actions on your turn, as you are compelled to flourish, gloat, pose, or otherwise waste your time in response." };
        }

        public override SourcePage GetSourcePage(ItemCurseSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("17a087ee-8738-4035-b4c5-12fe78ff84a7"),
                SourceId = GamemasteryGuide.ID,
                Page = 93
            };
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Rare";
            yield return "Cursed";
            yield return "Magical";
            yield return "Enchantment";
        }
    }
}
